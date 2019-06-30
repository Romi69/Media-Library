using MediaLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MediaLibrary.Test
{
    class TestDataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext db)
        {            
            /*Param boxOne = new Param() { ParamType = ParamType.Box, ParamId = 1, IntValue = 600, StringValue = "Box 1 (600)" };
            Param boxTwo = new Param() { ParamType = ParamType.Box, ParamId = 2, IntValue = 600, StringValue = "Box 2 (600)" };
            Param boxThree = new Param() { ParamType = ParamType.Box, ParamId = 3, IntValue = 700, StringValue = "Box 3 (700)" };

            db.Params.Add(boxOne);
            db.Params.Add(boxTwo);
            db.Params.Add(boxThree);*/
            

            Box one = new Box() { Name = "Box 1 (600)", Capacity = 600 };
            db.Params.Add(one.ConvertToParam());

            //Box two = new Box() { Name = "Box 2 (600)", Capacity = 600 };
            //Box three = new Box() { Name = "Box 3 (700)", Capacity = 700 };            

            Param manufVer = new Param() { ParamType = ParamType.Manufacturer, ParamId = 1, StringValue = "Verbatim" };
            Param manufPhil = new Param() { ParamType = ParamType.Manufacturer, ParamId = 2, StringValue = "Philips" };
            Param manufTdk = new Param() { ParamType = ParamType.Manufacturer, ParamId = 3, StringValue = "TDK" };

            db.Params.Add(manufVer);
            db.Params.Add(manufPhil);
            db.Params.Add(manufTdk);

            Param mediaCd = new Param() { ParamType = ParamType.MediaType, ParamId = 1, StringValue = "CD" };
            Param mediaCdRW = new Param() { ParamType = ParamType.MediaType, ParamId = 2, StringValue = "CD+RW" };
            Param mediaDVD = new Param() { ParamType = ParamType.MediaType, ParamId = 3, StringValue = "DVD" };

            db.Params.Add(mediaCd);
            db.Params.Add(mediaCdRW);
            db.Params.Add(mediaDVD);

            Param x = new Param() { ParamType = ParamType.Language, ParamId = 99, StringValue = "Törlendő nyelv" };
            db.Params.Add(x);


            db.SaveChanges();
            base.Seed(db);
        }
    }
}
