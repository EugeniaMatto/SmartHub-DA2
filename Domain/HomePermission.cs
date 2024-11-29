namespace SmartHub.Domain;

/// <summary>
/// Enumeración que representa los diferentes permisos que se pueden asignar a los usuarios en un hogar.
/// </summary>
public enum HomePermission
{
    /// <summary>
    /// Permite asociar dispositivos al hogar.
    /// </summary>
    AssociateDevices,

    /// <summary>
    /// Permite ver la lista de dispositivos asociados al hogar.
    /// </summary>
    ListDevices,

    /// <summary>
    /// Permite cambiar el nombre a los hardware del hogar
    /// </summary>
    ChangeDeviceName,

    /// <summary>
    /// Permite añadir habitaciones al hogar
    /// </summary>
    AddRooms,

    /// <summary>
    /// Permite cambiar de habitacion los hardware
    /// </summary>
    ChangeHardwareRoom
}
