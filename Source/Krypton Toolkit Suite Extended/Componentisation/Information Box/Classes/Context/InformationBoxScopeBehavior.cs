#region License
// <copyright file="InformationBoxScopeBehavior.cs" company="Johann Blais">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Johann Blais</author>
// <summary>Specifies constants defining how the new scope treats the parameters of the parent scopes</summary>
#endregion

namespace InformationBox.Classes.Context
{
    public enum InformationBoxScopeBehavior
    {
        NONE,
        INHERITPARENT,
        INHERITALL
    }
}