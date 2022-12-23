using API_REST_MVC.Models;
using API_REST_MVC.ViewModel;
using Application.Domain.Models;
using Application.Models;
using AutoMapper;

public class UtilisateurMapperProfile : Profile
{
    public UtilisateurMapperProfile()
    {
        CreateMap<UtilisateurBDD, UtilisateurMetier>();
        CreateMap<UtilisateurMetier, UtilisateurBDD>();
        CreateMap<UtilisateurMetier, UtilisateurMessage>();
        CreateMap<UtilisateurMessage, UtilisateurMetier>();
        CreateMap<UtilisateurMetier, UtilisateurViewModel>();
        CreateMap<UtilisateurViewModel, UtilisateurMetier>();
    }
}