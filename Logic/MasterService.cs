using System;
using System.Linq;

namespace Logic
{
    public class MasterService : IMasterService
    {
        private readonly IAlgoService _algoService;

        private readonly IDataService _dataService;
        
        public MasterService(IAlgoService algo, IDataService data)
        {            
            _algoService = algo;
            _dataService = data;

            if (_algoService == null)
            {
                throw new InvalidOperationException("We have no algoritm(null) to process");
            }

            CheckData(_dataService);
        }

        void CheckData(IDataService dataService)
        {            

            if (dataService == null)
            {
                throw new InvalidOperationException("We have no data(null) to process");
            }
            else 
            {
                var dataserv = dataService.GetAllData();
                if (!dataserv.Any())
                    throw new InvalidOperationException("We have no data(empty list) to process");
            }

        }

        public int GetDoubleSum()
        {            
            var data = _dataService.GetAllData();

            return _algoService.DoubleSum(data);;
        }

        //TODO: Make more methods
        public int MinValue()
        {
            var data = _dataService.GetAllData();            

            return _algoService.MinValue(data); ;
        }

        public double Function()
        {
            var data = _dataService.GetAllData();            

            return _algoService.Function(_dataService.GetElementAt(0), _algoService.GetAverage(data), _algoService.MinValue(data), GetMaxSquare()); ;
        }

        public double GetAverage()
        {
            var data = _dataService.GetAllData();
            return _algoService.GetAverage(data);
        }

        public double GetMaxSquare()
        {
            var data = _dataService.GetMax();
            return _algoService.Sqr(data);
        }
    }
}