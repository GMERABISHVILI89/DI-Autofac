﻿using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger,IDataAccess dataAccess) {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            _logger.Log("Starting the processing of Data");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processing Info");
            _logger.Log("Finished processing of the Data.");

        }
    }
}
