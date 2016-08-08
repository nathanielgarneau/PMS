using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.BLL.Interfaces;
using PMS.DAL.Repositories;
using PMS.ViewModel;

namespace PMS.BLL
{
    public class Setting : IBusinessLayer<SettingViewModel, int>, IViewModelConvertToDalModel<DAL.Model.Setting,SettingViewModel>
    {
         private readonly GenericDataRepository<DAL.Model.Setting> _repository =
            new GenericDataRepository<DAL.Model.Setting>();
        public void Add(SettingViewModel item)
        {
            var record = new DAL.Model.Setting
            {
                Name = item.Name,
                Value = item.Value
            };
            _repository.Insert(record);
        }
        public void Add(params SettingViewModel[] items)
        {
            var settings = new List<DAL.Model.Setting>();
            Parallel.ForEach(items, item =>
            {
                var record = new DAL.Model.Setting
                {
                    Name = item.Name,
                    Value = item.Value
                };
                lock (settings)
                {
                    settings.Add(record);
                }
            });
            _repository.Insert(settings);
        }
        public SettingViewModel Get(int id)
        {
            DAL.Model.Setting item = _repository.Select<DAL.Model.Setting>(id);
            var result = new SettingViewModel
            {
                Id = item.Id,
                Name = item.Name,
                Value = item.Value
            };
            return result;
        }
        public List<SettingViewModel> GetAll()
        {
            var items = _repository.SelectAll<DAL.Model.Setting>();
            var results = new List<SettingViewModel>();
            Parallel.ForEach(items, item =>
            {
                var result = new SettingViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Value = item.Value
                };
                lock (results)
                {
                    results.Add(result);
                }
            });
            return results;
        }

        public List<SettingViewModel> GetList(params int[] ids)
        {
            var results = new List<SettingViewModel>();
            Parallel.ForEach(ids, id =>
            {
                var item = Get(id);
                lock (results)
                {
                    results.Add(item);
                }
            });
            return results;
        }

        public void Remove(SettingViewModel item)
        {
           var record = new DAL.Model.Setting
                {
                    Name = item.Name,
                    Value = item.Value,
                    Id = item.Id
                };
            _repository.Delete(record);
        }
        public void Remove(params SettingViewModel[] items)
        {
            Parallel.ForEach(items, item =>
            {
                var record = new DAL.Model.Setting
                {
                    Name = item.Name,
                    Value = item.Value,
                    Id = item.Id
                };
                lock (_repository)
                {
                    _repository.Delete(record);
                }
            });
        }
        public void Update(SettingViewModel item)
        {
           var record = new DAL.Model.Setting
                {
                    Name = item.Name,
                    Value = item.Value,
                    Id = item.Id
                };
             _repository.Update(record);
        }
        public void Update(params SettingViewModel[] items)
        {
            var records = new List<DAL.Model.Setting>();
             Parallel.ForEach(items, item =>
            {
                var record = new DAL.Model.Setting
                {
                    Name = item.Name,
                    Value = item.Value,
                    Id = item.Id
                };
                lock (records)
                {
                    records.Add(record);
                }
            });
            _repository.Update(records);
        }

        public DAL.Model.Setting ConvertToDal(SettingViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public SettingViewModel ConvertToViewModel(DAL.Model.Setting model)
        {
            throw new NotImplementedException();
        }
    }
}
