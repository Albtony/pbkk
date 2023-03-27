using SQLite;
using Contact_Database.Models;

namespace Contact_Database
{
    public class ContactRepository
    {
        string _dbPath;
        private SQLiteAsyncConnection conn;

        public string StatusMessage { get; set; }

        private async Task Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);
            await conn.CreateTableAsync<Models.Contact>();
        }

        public ContactRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task AddNewContactData(int id, string contactName, string instituteName, string email, string institutePhoneNo, string privatePhoneNo)
        {
            int result;

            try
            {
                // Call Init()
                await Init();

                result = await conn.InsertAsync(new Models.Contact
                {
                    Id = id,
                    ContactName = contactName,
                    InstituteName = instituteName,
                    Email = email,
                    InstitutePhoneNo = institutePhoneNo,
                    PrivatePhoneNo = privatePhoneNo
                });

                StatusMessage = string.Format("{0} record(s) added [ID: {1})", result, id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
            }


        }

        public async Task<List<Models.Contact>> GetContactList()
        {
            try
            {
                await Init();
                return await conn.Table<Models.Contact>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Models.Contact>();
        }
    }
}
