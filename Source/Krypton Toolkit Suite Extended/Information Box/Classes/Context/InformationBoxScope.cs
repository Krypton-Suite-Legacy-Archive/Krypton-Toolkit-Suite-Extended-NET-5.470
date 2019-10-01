#region License
// <copyright file="InformationBoxScope.cs" company="Johann Blais">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Johann Blais</author>
// <summary>Represents the scope of a set of parameters for the InformationBoxes</summary>
#endregion

using System;
using System.Collections.Generic;

namespace InformationBox.Classes.Context
{
    /// <summary>
    /// Represents the scope of a set of parameters for the InformationBoxes.
    /// </summary>
    public class InformationBoxScope : IDisposable
    {
        #region Attributes
        /// <summary>
        /// Stack of all scopes
        /// </summary>
        private static readonly Stack<InformationBoxScope> _scopesStack = new Stack<InformationBoxScope>();

        /// <summary>
        /// Contains the parameters defined within the scope
        /// </summary>
        private readonly InformationBoxScopeParameters _definedParameters = new InformationBoxScopeParameters();
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="InformationBoxScope"/> class.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        public InformationBoxScope(InformationBoxScopeParameters parameters)
        {
            _definedParameters = parameters;

            _scopesStack.Push(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationBoxScope"/> class.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <param name="behavior">The behavior.</param>
        public InformationBoxScope(InformationBoxScopeParameters parameters, InformationBoxScopeBehavior behavior)
        {
            _definedParameters = parameters;

            EffectiveParameters = parameters;

            if (behavior == InformationBoxScopeBehavior.InheritParent)
            {
                if (null != Current)
                {
                    // Merge with the parameters defined explicitly in the direct parent
                    EffectiveParameters.Merge(Current.definedParameters);
                }
            }
            else if (behavior == InformationBoxScopeBehavior.InheritAll)
            {
                if (null != Current)
                {
                    // Merge the effective parameters from the parent
                    EffectiveParameters.Merge(Current.Parameters);
                }
            }

            _scopesStack.Push(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationBoxScope"/> class.
        /// </summary>
        public InformationBoxScope()
        {
            _scopesStack.Push(this);
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        /// <value>The parameters.</value>
        public InformationBoxScopeParameters Parameters
        {
            get { return this.EffectiveParameters; }
        }

        /// <summary>
        /// Gets the current scope.
        /// </summary>
        /// <value>The current.</value>
        internal static InformationBoxScope Current
        {
            get
            {
                if (_scopesStack.Count > 0)
                {
                    return _scopesStack.Peek();
                }

                return null;
            }
        }

        /// <summary>
        /// Gets or sets the effective parameters.
        /// </summary>
        /// <value>The effective parameters.</value>
        internal InformationBoxScopeParameters EffectiveParameters { get; set; }

        #endregion Properties

        #region Dispose
        public void Dispose()
        {
            _scopesStack.Pop();

            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
        }
        #endregion
    }
}