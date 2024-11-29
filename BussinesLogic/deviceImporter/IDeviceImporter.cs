using SmartHub.Domain;

namespace SmartHub.BussinesLogic.deviceImporter;

/// <summary>
/// Interfaz que define el contrato para los importadores de dispositivos.
/// </summary>
/// <remarks>
/// Esta interfaz debe ser implementada por cualquier clase que desee proporcionar una funcionalidad
/// para importar dispositivos desde diferentes fuentes de datos.
/// El propósito es permitir la extensibilidad de la aplicación, facilitando la integración
/// de nuevos formatos de importación sin modificar el código base.
/// Luego del desarrollo se deberá colocar el dll en la carpeta dlls (en el base path del proyecto)
/// con el nombre (TipoDeFuente)DeviceImporter.dll Ej. JsonDeviceImporter.dll.
/// </remarks>
public interface IDeviceImporter
{
    /// <summary>
    /// Importa una lista de dispositivos desde una fuente especificada.
    /// </summary>
    /// <param name="source">
    /// La ruta o ubicación de la fuente desde la que se importarán los dispositivos. Esto puede ser
    /// un archivo en formato JSON, XML, CSV, o cualquier otro formato compatible.
    /// </param>
    /// <returns>
    /// Una lista de objetos <see cref="Device"/> que representan los dispositivos importados.
    /// </returns>
    /// <exception cref="IOException">
    /// Se lanza si ocurre un error al leer la fuente especificada.
    /// </exception>
    /// <exception cref="FormatException">
    /// Se lanza si el formato de la fuente no es válido o no se puede analizar correctamente.
    /// </exception>
    List<Device> ImportDevices(string source);
}
