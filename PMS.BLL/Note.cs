using System.Collections.Generic;
using System.Linq;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class Note :GenericBusinessLayer<Xam.DAL.Model.Note, NoteViewModel> 
    {
         public Note()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Note>();
        }

        public override Xam.DAL.Model.Note ConvertToDal(NoteViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override NoteViewModel ConvertToViewModel(Xam.DAL.Model.Note model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.Note ToDal(NoteViewModel viewModel)
        {
            return new Xam.DAL.Model.Note
            {
                Id = viewModel.Id, 
                Value = viewModel.Value
            };
        }
        public static NoteViewModel ToViewModel(Xam.DAL.Model.Note model)
        {
            return new NoteViewModel
            {
                Id = model.Id,
                Value = model.Value
            };
        }
         public static IEnumerable<NoteViewModel> ToViewModel(IEnumerable<Xam.DAL.Model.Note> models)
           {
               return models.Select(model => ToViewModel(model)).ToList();
           }
         public static IEnumerable<Xam.DAL.Model.Note> ToDal(IEnumerable<NoteViewModel> models)
           {
               return models.Select(model => ToDal(model)).ToList();
           }
    }
}
