﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNOSquare.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UNOSquare.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Agregar.
        /// </summary>
        internal static string AddButton {
            get {
                return ResourceManager.GetString("AddButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Marca.
        /// </summary>
        internal static string BranchPlaceholder {
            get {
                return ResourceManager.GetString("BranchPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Modelo.
        /// </summary>
        internal static string ModelPlaceholder {
            get {
                return ResourceManager.GetString("ModelPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Debe Ingresar Todos Los Parámetros.
        /// </summary>
        internal static string NeedAllParametrs {
            get {
                return ResourceManager.GetString("NeedAllParametrs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No Se Permiten Parámetros Duplicados.
        /// </summary>
        internal static string NotDuplicated {
            get {
                return ResourceManager.GetString("NotDuplicated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Prueba.
        /// </summary>
        internal static string TitleMainPage {
            get {
                return ResourceManager.GetString("TitleMainPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Año.
        /// </summary>
        internal static string YearPlaceholder {
            get {
                return ResourceManager.GetString("YearPlaceholder", resourceCulture);
            }
        }
    }
}