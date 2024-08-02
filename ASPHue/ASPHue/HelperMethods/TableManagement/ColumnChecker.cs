using libraryhue.Data;
using libraryhue.Models.Characteristics;
using libraryhue.Models.Products;
using System.Reflection;

namespace ASPHue.HelperMethods.TableManagement
{
    public static class ColumnChecker
    {
        public static bool CheckField(string field, ProductTypesModel productType)
        {
            var type = GetType(productType);

            bool hasField = type.GetProperty(field) != null;

            return hasField;
        }

        public static string GetName(IProductsModel product)
        {
            var neopreneGear = (NeopreneGearsModel)product;

            // Si la conversión es exitosa, neopreneGear no será null y podemos acceder a la propiedad Name
            if (neopreneGear != null)
            {
                return neopreneGear.Name;
            }

            return "falló LOL";

        }

        public static int GetSize(IProductsModel product)
        {
            NeopreneGearsModel neo = (NeopreneGearsModel)product;
            return neo.SizeId;
        }

        public static string GetModel(IProductsModel product)
        {
            NeopreneGearsModel neo = (NeopreneGearsModel)product;
            return neo.Model;
        }
        public static string GetBrand(IProductsModel product)
        {
            NeopreneGearsModel neo = (NeopreneGearsModel)product;
            return neo.Brand;
        }

        public static Type GetType(ProductTypesModel productType)
        {
            switch(productType.Name)
            {
                case "Neoprene":
                    return typeof(NeopreneGearsModel);
                case "BCDs":
                    return typeof(BCDsModel);
                case "Hoods":
                    return typeof(HoodsModel);
                case "Masks":
                    return typeof(MasksModel);
                case "Octopus":
                    return typeof(OctopusModel);
                case "Tanks":
                    return typeof(TanksModel);
                case "Fins":
                    return typeof(FinsModel);
                default: return null;
            }
        }
    }
}
