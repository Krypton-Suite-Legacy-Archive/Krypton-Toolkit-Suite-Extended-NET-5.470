using System;
using System.Collections.Generic;
using System.Text;
using System.CodeDom.Compiler;
using System.IO;
using Microsoft.CSharp;

namespace PaletteRenderer.Classes
{
    public class Composer
    {
        #region Variables
        private string _outputFile, _namespace;

        private CSharpCodeProvider _provider;

        private List<string> _sources, _paletteItems;

        private CompilerParameters _compilerParameters;

        private StringBuilder _managerBuilder;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="Composer"/> class.
        /// </summary>
        /// <param name="outputFile">The output file.</param>
        /// <param name="nameSpace">The name space.</param>
        /// <param name="toolkitAssembly">The toolkit assembly.</param>
        public Composer(string outputFile, string nameSpace, string toolkitAssembly)
        {
            _outputFile = outputFile;

            _namespace = nameSpace;

            _provider = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v3.5" } });

            //_provider = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v15.0" } });

            _sources = new List<string>();

            _paletteItems = new List<string>();

            _compilerParameters = new CompilerParameters();

            _compilerParameters.ReferencedAssemblies.Add("System.dll");

            _compilerParameters.ReferencedAssemblies.Add("System.Core.dll");

            _compilerParameters.ReferencedAssemblies.Add("System.Data.dll");

            _compilerParameters.ReferencedAssemblies.Add("System.Xml.dll");

            _compilerParameters.ReferencedAssemblies.Add("System.Xml.Linq.dll");

            _compilerParameters.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll");

            _compilerParameters.ReferencedAssemblies.Add(toolkitAssembly);

            _compilerParameters.CompilerOptions = "";

            _compilerParameters.GenerateExecutable = false;

            _compilerParameters.GenerateInMemory = false;

            _compilerParameters.OutputAssembly = _outputFile;

            CreateManager();

            AddPaletteItemsClass();

            CreateAssemblyInfo();
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Finishes this instance.
        /// </summary>
        /// <returns></returns>
        public string Finish()
        {
            string _result = "";

            FinishManager();

            CompilerResults _compilerResults = _provider.CompileAssemblyFromSource(_compilerParameters, _sources.ToArray());

            if (_compilerResults.Errors.Count > 0)
            {
                _result = GetErrorText(_compilerResults.Errors);
            }

            return _result;
        }

        /// <summary>
        /// Adds the palette.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="name">The name.</param>
        public void AddPalette(string fileName, string name)
        {
            _compilerParameters.EmbeddedResources.Add(fileName);

            CreatePaletteClass(name, fileName);

            AddPaletteToManager(name);
        }
        #endregion

        #region Internal Methods
        private string GetErrorText(CompilerErrorCollection errorCollection)
        {
            string _result = "";

            foreach (CompilerError error in errorCollection)
            {
                _result += ("Error in line {0} :{1} , {2} \r\n".Frmt(error.Line, error.ErrorText, error.FileName));
            }

            return _result;
        }

        private void CreatePaletteClass(string name, string fileName)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Reflection;");
            sb.AppendLine(@"using System.IO;");
            sb.AppendLine(@"namespace " + _namespace + "{");
            sb.AppendLine();

            string className = GetClassName(name);
            string resourceName = GetResourceName(fileName);

            sb.Append(@"public partial class {0} : ComponentFactory.Krypton.Toolkit.KryptonPalette {{
        
        public string DisplayName {{ get {{ return {3}; }} }}
        
        public {0}() {{
            importPaletteFromResource();        
        }}
        
        private void importPaletteFromResource()
        {{
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream paletteStream = assembly.GetManifestResourceStream({1});
            if (paletteStream != null)
                Import(paletteStream);
            else
                throw new Exception({2});
        }}
        
        }}".Frmt(className, "\"" + resourceName + "\"", "\"Resource {0} not found!\"".Frmt(resourceName), "\"" + name + "\""));

            sb.AppendLine(@"}");

            // add to sources list
            _sources.Add(sb.ToString());
        }

        private string GetResourceName(string fileName)
        {
            return Path.GetFileName(fileName);
        }

        private string GetClassName(string name)
        {
            string result = name.Replace(" ", "");

            result = result.UppercaseFirst();

            return result;
        }

        private void CreateManager()
        {
            _managerBuilder = new StringBuilder();

            _managerBuilder.AppendLine(@"using System;");
            _managerBuilder.AppendLine(@"using System.Collections.Generic;");
            _managerBuilder.AppendLine(@"using System.Reflection;");
            _managerBuilder.AppendLine(@"namespace " + _namespace + "{");
            _managerBuilder.AppendLine();

            _managerBuilder.AppendLine("public static class PaletteManager {");

            _managerBuilder.AppendLine("private static PaletteItems _items;");
            _managerBuilder.AppendLine("public static PaletteItems Items {get { return _items; } }");

            _managerBuilder.Append(@"public static ComponentFactory.Krypton.Toolkit.KryptonPalette GetPalette(string name) {{
                ComponentFactory.Krypton.Toolkit.KryptonPalette result = null;

                PropertyInfo info = typeof(PaletteManager).GetProperty(name, BindingFlags.Static  | BindingFlags.Public);
                if (info != null)
                {{
                    result = (ComponentFactory.Krypton.Toolkit.KryptonPalette)info.GetValue(null,null);
                }}
                else                
                    throw new Exception(String.Format({0}, name));

                return result; }}".Frmt("\"Property {0} not found!\""));

            _managerBuilder.Append(@"public static void PreloadPalettes() {
                foreach(PaletteItem item in _items)
                    GetPalette(item.Name);
                 }");
        }

        private void FinishManager()
        {

            // add constructor
            _managerBuilder.Append(@"static PaletteManager() {
                _items = new PaletteItems();");
            foreach (string item in _paletteItems)
                _managerBuilder.AppendLine(item);

            _managerBuilder.AppendLine("}");

            // close class and namespace
            _managerBuilder.Append("}\r\n}");

            // add to sources
            _sources.Add(_managerBuilder.ToString());
        }

        private void AddPaletteToManager(string name)
        {
            string className = GetClassName(name);
            _managerBuilder.AppendLine("private static {0} _{0} = null;".Frmt(className));
            _managerBuilder.AppendLine(@"public static {0} {0} {{ 
                get {{ 
                    if (_{0} == null)
                        _{0} = new {0}();
                    return _{0};
                }} 
            }}".Frmt(className));

            _paletteItems.Add("_items.Add(\"{0}\",\"{1}\");".Frmt(className, name));
        }

        private void AddPaletteItemsClass()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Collections.Generic;");
            sb.AppendLine(@"namespace " + _namespace + "{");
            sb.AppendLine();

            sb.AppendLine(@"public class PaletteItems : List<PaletteItem> {
                public void Add(string name, string displayName) {
                    Add(new PaletteItem(name, displayName));
            } 
            }");

            sb.AppendLine(@"public class PaletteItem  {
            private string _name;
            private string _displayName;
            public string Name { get { return _name;} }
            public string DisplayName { get { return _displayName; } }

            public PaletteItem(string name, string displayName) {
                _name = name;
                _displayName = displayName;
            }");

            sb.AppendLine("}\r\n}");

            _sources.Add(sb.ToString());
        }


        private void CreateAssemblyInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System.Reflection;");
            sb.AppendLine("using System.Runtime.CompilerServices;");
            sb.AppendLine("using System.Runtime.InteropServices;");

            sb.AppendLine("[assembly: AssemblyTitle(\"{0}\")]".Frmt(_namespace));
            sb.AppendLine("[assembly: AssemblyDescription(\"Krypton palettes\")]");
            sb.AppendLine("[assembly: AssemblyConfiguration(\"\")]");
            sb.AppendLine("[assembly: AssemblyCompany(\"\")]");
            sb.AppendLine("[assembly: AssemblyProduct(\"{0}\")]".Frmt(Path.GetFileNameWithoutExtension(_outputFile)));
            sb.AppendLine("[assembly: AssemblyCopyright(\"Copyright ©  {0}\")]".Frmt(DateTime.Today.Year));
            sb.AppendLine("[assembly: AssemblyTrademark(\"\")]");
            sb.AppendLine("[assembly: AssemblyCulture(\"\")]");
            sb.AppendLine("[assembly: ComVisible(false)]");
            sb.AppendLine("[assembly: AssemblyVersion(\"1.0.0.0\")]");
            sb.AppendLine("[assembly: AssemblyFileVersion(\"1.0.0.0\")]");

            _sources.Add(sb.ToString());
        }
        #endregion
    }
}