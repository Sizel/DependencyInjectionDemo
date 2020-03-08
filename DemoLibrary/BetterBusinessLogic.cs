using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public class BetterBusinessLogic : IBusinessLogic
	{
        ILogger _logger;
        IDataAccess _dataAccess;

        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            ILogger logger = new Logger();
            IDataAccess dataAccess = new DataAccess();

            logger.Log("Starting the processing of data.");
            Console.WriteLine();
            Console.WriteLine("Processing the data");
            dataAccess.LoadData();
            dataAccess.SaveData("ProcessedInfo");
            Console.WriteLine();
            logger.Log("Finished processing of the data.");
        }
    }
}
