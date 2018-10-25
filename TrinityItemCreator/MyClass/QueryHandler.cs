

using System.Windows.Forms;

namespace TrinityItemCreator.MyClass
{
    class QueryHandler
    {
        public QueryHandler() { }

        public static string GetExportQuery()
        {
            // Initialize columns
            string Columns = string.Empty;
            foreach (var column in MyData.GetItemTemplateColumns())
            {
                Columns += $"`{column}`,";
            }
            // Initialize values
            string Values = string.Empty;
            foreach (var value in MyData.ItemTemplateValues)
            {
                Values += $"'{value}',";
            }

            string SQLQuery = "-- Item created with TrinityItemCreator\n" 
                + Properties.Settings.Default.SQLPrefix
                + $" INTO `item_template` ({Columns.Remove(Columns.Length - 1)}) VALUES \n({Values.Remove(Values.Length - 1)})";

            return SQLQuery;
        }
    }
}
