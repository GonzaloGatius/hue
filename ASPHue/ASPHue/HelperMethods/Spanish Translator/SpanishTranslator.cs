using libraryhue.Data;

namespace ASPHue.HelperMethods
{
    public static class SpanishTranslator
    {
        public static string GetTranslatedProductName(string product)
        {
            switch (product)
            {
                case "Neoprene":
                    return "Neoprene";
                case "BCDs":
                    return "Chaleco comp.";
                case "Hoods":
                    return "Cascos";
                case "Masks":
                    return "Lunetas";
                case "Octopus":
                    return product;
                case "Tanks":
                    return "Tanques";
                case "Fins":
                    return "Aletas";
                case "Weights":
                    return "Pesos";
                default:
                    return "Neoprene";
            }
        }
    }
}
