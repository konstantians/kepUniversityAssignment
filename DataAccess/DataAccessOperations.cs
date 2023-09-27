using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace DataAccess
{
    public class DataAccessOperations
    {
        private static string ConnectionString { get; } = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        private static SQLiteConnection connection = new SQLiteConnection(ConnectionString);

        public static List<Citizen> GetCitizens()
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "SELECT * FROM Citizen;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<Citizen> citizens = new List<Citizen>();

            while (reader.Read())
            {
                Citizen citizen = new Citizen();

                citizen.AFM = reader.GetString(0);
                citizen.AMKA = reader.GetString(1);
                citizen.FullName = reader.GetString(2);
                citizen.DateOfBirth = reader.GetString(3);
                citizen.Address = reader.GetString(4);
                citizen.Email= reader.GetString(5);
                citizen.PhoneNumber = reader.GetString(6);

                citizens.Add(citizen);
            }

            closeConnectionIfOpenedHere(openedHere);
            return citizens;
        }

        public static List<Petition> GetPetitions()
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "SELECT * FROM Petition;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<Petition> petitions = new List<Petition>();

            while (reader.Read())
            {
                Petition petition = new Petition();

                petition.PetitionId = reader.GetInt32(0);
                petition.PetitionAlias = reader.GetString(1);
                petition.PetitionType = reader.GetString(2);
                petition.PetitionDate = reader.GetString(3);
                petition.PetitionDescription = reader.GetString(4);
                petition.PetitionStatus = reader.GetString(5);
                petition.CitizenAfmOfPetition = reader.GetString(6);

                petitions.Add(petition);
            }

            closeConnectionIfOpenedHere(openedHere);
            return petitions;
        }

        public static List<KepEmployee> GetKepEmployees()
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "SELECT * FROM KEPEmployee;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<KepEmployee> kepEmployees = new List<KepEmployee>();

            while (reader.Read())
            {
                KepEmployee kepEmployee = new KepEmployee();

                kepEmployee.Username = reader.GetString(0);
                kepEmployee.Password = reader.GetString(1);
                kepEmployee.AccountType = reader.GetString(2);
                kepEmployee.RecoveryQuestion = reader.GetString(3);
                kepEmployee.RecoveryAnswer = reader.GetString(4);

                kepEmployees.Add(kepEmployee);
            }

            closeConnectionIfOpenedHere(openedHere);
            return kepEmployees;
        }

        public static Citizen GetCitizen(string afm)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "SELECT * FROM Citizen WHERE AFM = @afm;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@afm", afm);
            SQLiteDataReader reader = command.ExecuteReader();

            Citizen citizen = new Citizen();

            while (reader.Read())
            {
                citizen.AFM = reader.GetString(0);
                citizen.AMKA = reader.GetString(1);
                citizen.FullName = reader.GetString(2);
                citizen.DateOfBirth = reader.GetString(3);
                citizen.Address = reader.GetString(4);
                citizen.Email = reader.GetString(5);
                citizen.PhoneNumber = reader.GetString(6);
               
            }
            closeConnectionIfOpenedHere(openedHere);

            return citizen;
        }

        public static Petition GetPetition(int petitionId)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "SELECT * FROM Petition WHERE PetitionId = @petitionId;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@petitionId", petitionId);
            SQLiteDataReader reader = command.ExecuteReader();

            Petition petition = new Petition();

            while (reader.Read())
            {
                petition.PetitionId = reader.GetInt32(0);
                petition.PetitionAlias = reader.GetString(1);
                petition.PetitionType = reader.GetString(2);
                petition.PetitionDate = reader.GetString(3);
                petition.PetitionDescription = reader.GetString(4);
                petition.PetitionStatus = reader.GetString(5);
                petition.CitizenAfmOfPetition = reader.GetString(6);
            }
            closeConnectionIfOpenedHere(openedHere);

            return petition;
        }

        public static KepEmployee GetKepEmployee(string username)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "SELECT * FROM KEPEmployee WHERE Username = @username;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@username", username);
            SQLiteDataReader reader = command.ExecuteReader();

            KepEmployee kepEmployee = new KepEmployee();

            while (reader.Read())
            {
                kepEmployee.Username = reader.GetString(0);
                kepEmployee.Password = reader.GetString(1);
                kepEmployee.AccountType = reader.GetString(2);
                kepEmployee.RecoveryQuestion = reader.GetString(3);
                kepEmployee.RecoveryAnswer = reader.GetString(4);
            }

            kepEmployee.RegisteredCitizens = ReturnCitizensOfEmployee(username);

            closeConnectionIfOpenedHere(openedHere);
            return kepEmployee;
        }

        public static void CreateCitizen(Citizen citizen, string employeeUsername)
        {
            //check for other citizens with the same afm
            if(GetCitizen(citizen.AFM).AFM != null)
            {
                throw new Exception("there is another citizen with the given AFM");
            }

            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "INSERT INTO Citizen(AFM, AMKA, FullName, DateOfBirth, Address, Email, PhoneNumber, KepEmployeeUsername) " +
                "VALUES(@afm, @amka, @fullName, @dateOfBirth, @address, @email, @phoneNumber, @employeeUsername);";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@afm", citizen.AFM);
            command.Parameters.AddWithValue("@amka", citizen.AMKA);
            command.Parameters.AddWithValue("@fullName", citizen.FullName);
            command.Parameters.AddWithValue("@dateOfBirth", citizen.DateOfBirth);
            command.Parameters.AddWithValue("@address", citizen.Address);
            command.Parameters.AddWithValue("@email", citizen.Email);
            command.Parameters.AddWithValue("@phoneNumber", citizen.PhoneNumber);
            command.Parameters.AddWithValue("@employeeUsername", employeeUsername);
            command.ExecuteNonQuery();
            
            closeConnectionIfOpenedHere(openedHere);
        }

        public static void CreatePetition(Petition petition)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "INSERT INTO Petition(PetitionAlias, PetitionType, PetitionDate, PetitionDescription, PetitionStatus, CitizenAFM) " +
                "VALUES(@petitionAlias, @petitionType, @petitionDate, @petitionDescription, @petitionStatus, @citizenAFM);";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@petitionAlias", petition.PetitionAlias);
            command.Parameters.AddWithValue("@petitionType", petition.PetitionType);
            command.Parameters.AddWithValue("@petitionDate", petition.PetitionDate);
            command.Parameters.AddWithValue("@petitionDescription", petition.PetitionDescription);
            command.Parameters.AddWithValue("@petitionStatus", petition.PetitionStatus);
            command.Parameters.AddWithValue("@citizenAFM", petition.CitizenAfmOfPetition);
            command.ExecuteNonQuery();
            
            closeConnectionIfOpenedHere(openedHere);
        }

        public static void CreateKepEmployee(KepEmployee kepEmployee)
        {
            //check for other users
            if (GetKepEmployee(kepEmployee.Username).Username != null)
            {
                throw new Exception("there is another kep Employee with the same username");
            }

            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "INSERT INTO KEPEmployee(Username, Password, AccountType, RecoveryQuestion, RecoveryAnswer) " +
                "VALUES(@username, @password, @accountType, @recoveryQuestion, @recoveryAnswer);";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@username", kepEmployee.Username);
            command.Parameters.AddWithValue("@password", kepEmployee.Password);
            command.Parameters.AddWithValue("@accountType", kepEmployee.AccountType);
            command.Parameters.AddWithValue("@recoveryQuestion", kepEmployee.RecoveryQuestion);
            command.Parameters.AddWithValue("@recoveryAnswer", kepEmployee.RecoveryAnswer);
            command.ExecuteNonQuery();
            
            closeConnectionIfOpenedHere(openedHere);
        }

        public static void DeleteCitizen(string afm)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            //delete the citizen's petitions first
            List<Petition> citizenPetitions = ReturnPetitionsOfCitizen(afm);
            foreach(Petition petition in citizenPetitions)
            {
                DeletePetition(petition.PetitionId);
            }

            string sqlQuery = "DELETE FROM Citizen WHERE AFM = @afm;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@afm", afm);
            command.ExecuteNonQuery();
            
            closeConnectionIfOpenedHere(openedHere);
        }

        public static void DeletePetition(int petitionId)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "DELETE FROM Petition WHERE PetitionId = @petitionId;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@petitionId", petitionId);
            command.ExecuteNonQuery();
            
            closeConnectionIfOpenedHere(openedHere);
        }

        public static void DeleteKepEmployee(string username)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "DELETE FROM KEPEmployee WHERE Username = @username;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@username", username);
            command.ExecuteNonQuery();
            
            closeConnectionIfOpenedHere(openedHere);
        }

        public static void UpdateCitizen(Citizen citizen, string oldAFM)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "UPDATE Citizen " +
                "SET AMKA = @amka, FullName = @fullName, DateOfBirth = @dateOfBirth, " +
                "Address = @address, Email = @email, PhoneNumber = @phoneNumber " +
                "WHERE AFM = @afm;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@afm", citizen.AFM);
            command.Parameters.AddWithValue("@amka", citizen.AMKA);
            command.Parameters.AddWithValue("@fullName", citizen.FullName);
            command.Parameters.AddWithValue("@dateOfBirth", citizen.DateOfBirth);
            command.Parameters.AddWithValue("@address", citizen.Address);
            command.Parameters.AddWithValue("@email", citizen.Email);
            command.Parameters.AddWithValue("@phoneNumber", citizen.PhoneNumber);
            command.Parameters.AddWithValue("@oldAFM", oldAFM);
            command.ExecuteNonQuery();
            
            closeConnectionIfOpenedHere(openedHere);
        }

        public static void UpdatePetition(Petition petition)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "UPDATE Petition " +
                "SET PetitionAlias = @petitionAlias, PetitionType = @petitionType, PetitionDate = @petitionDate, " +
                "PetitionDescription = @petitionDescription, PetitionStatus = @petitionStatus, CitizenAFM = @citizenAFM " +
                "WHERE PetitionId = @petitionId";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@petitionId", petition.PetitionId);
            command.Parameters.AddWithValue("@petitionAlias", petition.PetitionAlias);
            command.Parameters.AddWithValue("@petitionType", petition.PetitionType);
            command.Parameters.AddWithValue("@petitionDate", petition.PetitionDate);
            command.Parameters.AddWithValue("@petitionDescription", petition.PetitionDescription);
            command.Parameters.AddWithValue("@petitionStatus", petition.PetitionStatus);
            command.Parameters.AddWithValue("@citizenAFM", petition.CitizenAfmOfPetition);
            command.ExecuteNonQuery();
            
            closeConnectionIfOpenedHere(openedHere);
        }

        public static void UpdateKepEmployee(KepEmployee kepEmployee)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "UPDATE KEPEmployee " +
                "SET Password = @password, AccountType = @accountType, RecoveryQuestion = @recoveryQuestion, RecoveryAnswer = @recoveryAnswer " +
                "WHERE Username = @username;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@username", kepEmployee.Username);
            command.Parameters.AddWithValue("@password", kepEmployee.Password);
            command.Parameters.AddWithValue("@accountType", kepEmployee.AccountType);
            command.Parameters.AddWithValue("@recoveryQuestion", kepEmployee.RecoveryQuestion);
            command.Parameters.AddWithValue("@recoveryAnswer", kepEmployee.RecoveryAnswer);
            command.ExecuteNonQuery();
            
            closeConnectionIfOpenedHere(openedHere);
        }

        public static void UpdateKepEmployeeAndUsername(KepEmployee kepEmployee, string newUsername)
        {
            //if the newUsername and old username are the same skip the complicated process and do the simple thing
            if(kepEmployee.Username == newUsername)
            {
                UpdateKepEmployee(kepEmployee);
                return;
            }

            //check for other users
            if (GetKepEmployee(newUsername).Username != null)
            {
                throw new Exception("there is another kep Employee with the given username");
            }

            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            //delete the citizens that had the old employee name
            List<Citizen> citizens = ReturnCitizensOfEmployee(kepEmployee.Username);
            citizens.ForEach(citizen => DeleteCitizen(citizen.AFM));

            string sqlQuery = "UPDATE KEPEmployee " +
                "SET Username = @newUsername, Password = @password, AccountType = @accountType, " +
                "RecoveryQuestion = @recoveryQuestion, RecoveryAnswer = @recoveryAnswer " +
                "WHERE Username = @username;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@username", kepEmployee.Username);
            command.Parameters.AddWithValue("@password", kepEmployee.Password);
            command.Parameters.AddWithValue("@accountType", kepEmployee.AccountType);
            command.Parameters.AddWithValue("@recoveryQuestion", kepEmployee.RecoveryQuestion);
            command.Parameters.AddWithValue("@recoveryAnswer", kepEmployee.RecoveryAnswer);
            command.Parameters.AddWithValue("@newUsername", newUsername);
            command.ExecuteNonQuery();

            //add the citizens with the new employee name
            citizens.ForEach(citizen => CreateCitizen(citizen, newUsername));

            closeConnectionIfOpenedHere(openedHere);
        }

        public static List<Petition> ReturnPetitionsOfCitizen(string citizenAFM)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "SELECT * FROM Petition JOIN Citizen ON " +
                "Petition.CitizenAFM = Citizen.AFM WHERE Petition.CitizenAFM = @citizenAFM;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@citizenAFM", citizenAFM);
            SQLiteDataReader reader = command.ExecuteReader();

            List<Petition> petitions = new List<Petition>();

            while (reader.Read())
            {
                Petition petition = new Petition();

                petition.PetitionId = reader.GetInt32(0);
                petition.PetitionAlias = reader.GetString(1);
                petition.PetitionType = reader.GetString(2);
                petition.PetitionDate = reader.GetString(3);
                petition.PetitionDescription = reader.GetString(4);
                petition.PetitionStatus = reader.GetString(5);
                petition.CitizenAfmOfPetition = reader.GetString(6);

                petitions.Add(petition);
            }

            closeConnectionIfOpenedHere(openedHere);

            return petitions;
        }

        public static List<Citizen> ReturnCitizensOfEmployee(string username)
        {
            bool openedHere = checkConnectionAlreadyOpenAndOpenIfNecessary();

            string sqlQuery = "SELECT * FROM Citizen JOIN KEPEmployee ON " +
                "KEPEmployee.Username = Citizen.KepEmployeeUsername WHERE Citizen.KepEmployeeUsername = @username;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@username", username);
            SQLiteDataReader reader = command.ExecuteReader();

            List<Citizen> citizens = new List<Citizen>();

            while (reader.Read())
            {
                Citizen citizen = new Citizen();

                citizen.AFM = reader.GetString(0);
                citizen.AMKA = reader.GetString(1);
                citizen.FullName = reader.GetString(2);
                citizen.DateOfBirth = reader.GetString(3);
                citizen.Address = reader.GetString(4);
                citizen.Email = reader.GetString(5);
                citizen.PhoneNumber = reader.GetString(6);

                citizens.Add(citizen);
            }

            closeConnectionIfOpenedHere(openedHere);

            return citizens;
        }

        private static bool checkConnectionAlreadyOpenAndOpenIfNecessary()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                return true;
            }
            return false;
        }

        private static void closeConnectionIfOpenedHere(bool openedHere)
        {
            if (openedHere)
                connection.Close();
        }
    }
}

