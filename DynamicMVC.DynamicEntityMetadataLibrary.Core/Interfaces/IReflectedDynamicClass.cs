﻿using ReflectionLibrary.Interfaces;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces
{
    /// <summary>
    /// Reflected class  for Dynamic MVC
    /// </summary>
    public interface IReflectedDynamicClass : IReflectedClass
    {
        /// <summary>
        /// Controller reflected class
        /// </summary>
        IReflectedClass ControllerReflectedClass { get; set; }
    }
}
