using System;
using System.Collections.Generic;
using System.Linq;
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
        #endregion
    }
}