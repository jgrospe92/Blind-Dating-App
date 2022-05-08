using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevTeamProject
{
    // Class to manages User class to the form class
    public class HelperClass
    {
        // Reference to the database
        private static Root database = Database.LoadDb();

        // Reference to the current usr
        public USER currentUser;

        // Holds all the record of users in the database;
        public List<USER> users = database.USER;

        // Holds match usrers
        public List<USER> matchUsers = new List<USER>();

        // Holds filtered search Users
        public List<USER> filteredUsers = new List<USER>();

        // Reference for the search tag
        public string Tag { set; get; }

        // Not a good design if we have a huge databse
        // Return true if userId and userPass exist
        public bool VerifyUser(string username, string pass)
        {
         foreach(var v in users)
            {
                if(v.Username == username)
                {
                    if (v.Password.Equals(pass))
                    {
                        currentUser = v;
                        return true;               
                    }
                }
            }
            return false;
        }

        // Uncheck checkedlistBox
        public void UncheckedList(CheckedListBox cl)
        {
            foreach(int i in cl.CheckedIndices)
            {
                cl.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        // returns the count of the total users
        public int CountTotalUsers()
        {
            int reuslt = users.Count();
            return reuslt;
        }
        // sets usr traits
        public void SetUserTraits(CheckedListBox ch, USER newUser)
        {
            newUser.Traits = new List<string>();
            for (int i = 0; i < ch.Items.Count; i++)
            {
                if (ch.GetItemChecked(i))
                {
                    string trait = (string)ch.Items[i];                
                   
                   
                    newUser.Traits.Add(trait.ToLower());
                }
            }
        }

        // sets usr likes
        public void SetUserLikes(CheckedListBox ch, USER newUser)
        {
            newUser.Likes = new List<string>();
            for (int i = 0; i < ch.Items.Count; i++)
            {
                if (ch.GetItemChecked(i))
                {
                    string likes = (string)ch.Items[i];    
                    newUser.Likes.Add(likes.ToLower());
                }
            }

        }
        // Set the id based on the number of current users
        public void loadDataToProfile(TextBox text)
        {
            text.Text = users.Count.ToString();
        }

        // returns current user
        public USER loadCurrentUser()
        {
            return currentUser;
        }

        public USER getUserById(int id)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }
        
        // get user by index
        public USER getUserByIndex(int index)
        {
            USER user = new USER();
            if(matchUsers.Count > 0)
            {
                user = matchUsers[index];
            }
            return user;
        }

        // Serialized objects
        public void AddnewUserToDB()
        {
    
            try
            {
                string path = @"F:\gitHub\App-Dev-Team-Project\AppDevTeamProject\JsonData\Members.json";
                string record = JsonConvert.SerializeObject(database);
                
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (var writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(record.ToString());
                    writer.Close();
                }
          
            }
            catch (Exception)
            {
                MessageBox.Show("Error getting JSON data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }

        // Methods for matching users
        public int getTotalMatch()
        {
            return matchUsers.Count();
        }

        public int getFilterListSize()
        {
            return filteredUsers.Count();
        }

        public bool addMatchUserToList()
        {
            foreach(USER data in users)
            {
                if (!currentUser.Username.Equals(data.Username))
                {
                  
                    if (currentUser.Likes.Select(x => x).Intersect(data.Traits).Any())
                    {
                        matchUsers.Add(data);
                    }

                }
            }
            return true;
        }

        // Clears the list of matches
        public void clearMatches()
        {
            matchUsers.Clear();
        }

        // Filtered search method
        public void FilteredSearchByTraits(string str)
        {
            foreach (USER data in users)
            {
                if (!currentUser.Username.Equals(data.Username))
                {

                    if (data.Traits.Contains(str))
                    {
                        filteredUsers.Add(data);
                    }
                  
                }
            }
        }

        // Clears the list of matches
        public void clearFilter()
        {
            filteredUsers.Clear();
        }

        public bool VerifiySearch(string str)
        {

            if (str.Equals("stable") || str.Equals("fun") || str.Equals("rich") || str.Equals("sweet") || str.Equals("religious") ||
                str.Equals("respectful") || str.Equals("charismatic") || str.Equals("tough") || str.Equals("loyal") || str.Equals("smart") ||
                 str.Equals("lustful") || str.Equals("wild") || str.Equals("short") || str.Equals("tall"))
            {
                return true;
            }

            return false;
        }

       

    }
}
