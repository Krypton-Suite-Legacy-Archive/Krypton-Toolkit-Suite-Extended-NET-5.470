#region License
// <copyright file="AsyncResultCallBack.cs" company="Johann Blais">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Johann Blais</author>
// <summary>Contains a delegate for the asynchronous callback result</summary>
#endregion

using InformationBox.Enumerations;

namespace InformationBox.Classes.Common
{
    /// <summary>
    /// Delegate used when a box is closed to inform the caller.
    /// </summary>
    /// <param name="result">The result.</param>
    public delegate void AsyncResultCallback(InformationBoxResult result);
}