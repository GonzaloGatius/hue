namespace ASPHue.HelperMethods.TableManagement
{
    public static class ColumnChecker
    {
        public static bool CheckIfName(string productTypeName)
        {
            switch (productTypeName) 
            {
                case "Neoprene":
                case "Hoods":
                case "Tanks":
                    return true;
                default: return false;
            }
        }

        public static bool CheckIfModel(string productTypeName)
        {
            switch (productTypeName)
            {
                case "BCDs":
                case "Fins":
                case "Masks":
                case "Octopus":
                case "Tanks":
                    return true;
                default: return false;
            }
        }

        public static bool CheckIfBrand(string productTypeName)
        {
            switch (productTypeName)
            {
                case "BCDs":
                case "Fins":
                case "Hoods":
                case "Masks":
                case "Neoprene":
                case "Octopus":
                    return true;
                default: return false;
            }
        }
    }
}
