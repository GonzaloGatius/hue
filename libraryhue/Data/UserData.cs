﻿using libraryhue.DB;
using libraryhue.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Data
{
    public class UserData : DataManager, IUserData
    {
        private readonly IDataAccess dataAccess;
        private readonly ConnectionStringData connectionStringData;

        protected override string tableName { get; set; } = "Users";
        protected override string spCreateName { get; set; } = "spUsers_create";
        protected override string spUpdateName { get; set; } = "";

        public UserData(IDataAccess dataAccess, ConnectionStringData connectionStringData): base(dataAccess, connectionStringData)
        {
            this.dataAccess = dataAccess;
            this.connectionStringData = connectionStringData;
        }
    }

    public interface IUserData : IDataManager
    {

    }
}
