using ModeloValidador.Abstracciones;

namespace AlphanumericModelValidator;
public class AlphanumericValidator : IModeloValidador
{
    public bool EsValido(Modelo modelo)
    {
        if (modelo.Value.Length != 6)
        {
            return false;
        }

        for (var i = 0; i < 3; i++)
        {
            if (!char.IsLetter(modelo.Value[i]))
            {
                return false;
            }
        }

        for (var i = 3; i < 6; i++)
        {
            if (!char.IsDigit(modelo.Value[i]))
            {
                return false;
            }
        }

        return true;
    }
}
