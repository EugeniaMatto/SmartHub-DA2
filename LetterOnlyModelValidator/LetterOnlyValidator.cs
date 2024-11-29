using ModeloValidador.Abstracciones;

namespace LetterOnlyModelValidator;

public class LetterOnlyValidator : IModeloValidador
{
    public bool EsValido(Modelo modelo)
    {
        if (modelo.Value.Length != 6)
        {
            return false;
        }

        foreach (var c in modelo.Value)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }

        return true;
    }
}
