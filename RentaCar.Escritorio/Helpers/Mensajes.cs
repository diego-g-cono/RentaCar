using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Escritorio.Helpers
{
    public static class Mensajes
    {
        // validaciones
        public static string CampoVacio(string campo) => $"El campo {campo} no puede estar vacío.";

        public static string FormatoInvalido(string campo) => $"El formato del campo {campo} es inválido.";

        public static string LicenciaVencida => "La licencia del conductor está vencida.";

        public static string TanqueLleno => "Debe indicar si el tanque está lleno.";

        public static string FechaInicioMayorFechaFin => "La fecha de inicio no puede ser mayor a la fecha de fin.";

        public static string FechaRetiroInvalida => "La fecha de retiro no puede ser anterior a la fecha actual.";

        public static string SeleccioneEntidad(string entidad) => $"No se ha seleccionado ningún {entidad}";

        public static string CantidadInvalidaDigitos(string entidad) => $"Cantidad de dígitos inválida para {entidad}.";

        public static string CompleteCamposObligatorios => "Debe completar todos los campos.";

        //confirmaciones
        public static string ConfirmarEliminacion(string entidad) => $"¿Está seguro que desea eliminar {entidad}?";

        public static string ConfirmarGuardado(string entidad) => $"¿Está seguro que desea guardar {entidad}?";

        public static string ConfirmarCancelacion() => $"¿Está seguro que desea cancelar la operación? Se perderan los datos ingresados.";

        //resultados
        public static string ExitoGuardado(string entidad) => $"{entidad} guardado correctamente.";

        public static string ExitoEdicion(string entidad) => $"{entidad} editado correctamente.";

        public static string ExitoEliminacion(string entidad) => $"{entidad} eliminado correctamente.";

        

    }
}
