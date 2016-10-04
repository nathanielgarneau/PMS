namespace PMS.BLL.Interfaces
{
    internal interface IViewModelConvertToDalModel<T, TX>
    {
        T ConvertToDal(TX viewModel);
        TX ConvertToViewModel(T model);
    }
}