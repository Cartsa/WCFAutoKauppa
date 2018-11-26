using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.controller
{
    
    public class AutoRegisterHandler
    {
        DatabaseControllerService.Service1Client DbClient = new DatabaseControllerService.Service1Client();
        public bool TestDatabaseConnection()
        {
            bool doesItWork = DbClient.connectDatabase();
            return doesItWork;
        }
        
        public bool saveAuto(DatabaseControllerService.AutoTesti newAuto) 
        {
            bool didItGoIntoDatabase = DbClient.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<DatabaseControllerService.AutonMerkki> getAllAutoMakers()
        {
            List<DatabaseControllerService.AutonMerkki> Merkit = DbClient.getAllAutoMakersFromDatabase();
            return Merkit;
        }
        
        public List<DatabaseControllerService.AutonMalli> getAutoModels(int makerId)
        {
            List<DatabaseControllerService.AutonMalli> Mallit = DbClient.getAutoModelsByMakerId(makerId);
            return Mallit;
        }
        public List<DatabaseControllerService.Polttoaine> getFuel() {
            List<DatabaseControllerService.Polttoaine> Polttoaineet = DbClient.getCarFuel();
            return Polttoaineet;
        }
        public List<DatabaseControllerService.Vari> getColor()
        {
            List<DatabaseControllerService.Vari> Varit = DbClient.getColor();
            return Varit;
        }
        public DatabaseControllerService.AutoTesti getSeuraavaAuto(int autoID)
        {
            return DbClient.Seuraava(autoID);
        }
        public DatabaseControllerService.AutoTesti getEkaAuto()
        {
            return DbClient.Eka();
        }
        public DatabaseControllerService.AutoTesti getEdellinenAuto(int autoID)
        {
            return DbClient.Edellinen(autoID);
        }
        public DatabaseControllerService.AutoTesti getVikaAuto()
        {
            return DbClient.Vika();
        }
    }
}
