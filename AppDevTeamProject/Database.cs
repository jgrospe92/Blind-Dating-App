using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevTeamProject
{
    public class Database
    {

        // Load the initial data
      

        public static Root LoadDb()
        {
            // retieves objects from the json file
            // Make sure you have the right path
            // The json data is under JsonData
            
            try
            {
                string fileName = @"F:\gitHub\App-Dev-Team-Project\AppDevTeamProject\JsonData\Members.json";
                string jsonText = File.ReadAllText(fileName);
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(jsonText);
                return data;
            }
           catch (Exception)
            {
                MessageBox.Show("Error getting JSON data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            return null;
        }


    }

    public class UserCharacters
    {
        private string[] interest = { "Stable", "Fun", "Rich", "Sweet", "Respectful", "Wild", "Charismatic", "Smart", 
            "Tough", "Loyal", "Short", "Tall", "Religious", "Horny"};   
  
    }
}
