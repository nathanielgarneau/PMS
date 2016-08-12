using System;
using System.Collections.Generic;
using System.Linq;

using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class Note :GenericBusinessLayer<DAL.Model.Note, NoteViewModel> 
    {
         public Note()
        {
            Repository = new GenericDataRepository<DAL.Model.Note>();
        }

        public override DAL.Model.Note ConvertToDal(NoteViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override NoteViewModel ConvertToViewModel(DAL.Model.Note model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Note ToDal(NoteViewModel viewModel)
        {
            return new DAL.Model.Note
            {
                Id = viewModel.Id, 
                Value = viewModel.Value
            };
        }
        public static NoteViewModel ToViewModel(DAL.Model.Note model)
        {
            return new NoteViewModel
            {
                Id = model.Id,
                Value = model.Value
            };
        }
         public static IEnumerable<NoteViewModel> ToViewModel(IEnumerable<DAL.Model.Note> models)
           {
               return models.Select(model => ToViewModel(model)).ToList();
           }
         public static IEnumerable<DAL.Model.Note> ToDal(IEnumerable<NoteViewModel> models)
           {
               return models.Select(model => ToDal(model)).ToList();
           }
    }
}
