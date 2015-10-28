using AutoMapper;
using ProjetoModeloDDD.Model.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        //public override string ProfileName
        //{
        //    get { return "DomainToViewModelMappings"; }
        //}

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }

    }
}