using SQLite;
using BMI_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BMI_Calculator
{
    public class BMIRepository
    {
        string _dbPath;
        private SQLiteAsyncConnection conn;

        public string StatusMessage { get; set; }

        // TODO: Add variable for the SQLite connection

        private async Task Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);
            await conn.CreateTableAsync<BMIData>();
        }

        public BMIRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task AddNewBMIData(string name, double height, double weight, double bmiscore, string bmiresult, string timestamp)
        {
            int result;

            try
            {
                // Call Init()
                await Init();

                // basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                result = await conn.InsertAsync(new BMIData
                {
                    Name = name,
                    Height = height,
                    Weight = weight,
                    BMIScore = bmiscore,
                    BMIResult = bmiresult,
                    TimeStamp = timestamp
                });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
            }

            
        }

        public async Task<List<BMIData>> GetBMIList()
        {
            try
            {
                await Init();
                return await conn.Table<BMIData>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<BMIData>();
        }
    }
}
