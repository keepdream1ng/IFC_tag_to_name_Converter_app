using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryGym.Ifc;

namespace IFC_tag_to_name_Converter
{
    internal static class IFCConverter
    {
        public static bool PutTagInIFCName(string ifcFilePath)
        {
            if (!File.Exists(ifcFilePath)) { return false; }
            DatabaseIfc db = new DatabaseIfc(ifcFilePath);
            foreach (var part in db.Project.Extract<IfcElement>())
            {
                var name = part.Name;
                // Skipping tekla bolts.
                if (name == "Bolt assembly") { continue; }
                part.Name = part.Tag;
                var newName = part.Name;

                Console.WriteLine($"{name}  =>  {newName}");
            }
            return db.WriteFile(ifcFilePath);
        }
    }
}
