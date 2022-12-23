using Application.Domain.Interfaces;
using Application.Domain.Models;
using Application.Repositories;
using AutoMapper;

namespace Application.UseCases;

public class UtilisateursRepository : IUtilisateursRepository
{
    private readonly IMapper _mapper;
    private readonly UtilisateursContext _context;

    public UtilisateursRepository(IMapper mapper, UtilisateursContext context)
    {
        _mapper = mapper;
        _context = context;
    }


    public List<UtilisateurMetier> GetUtilisateurs()
    {
        var utilisateurs = this._context.Utilisateurs.ToList();
        return _mapper.Map<List<UtilisateurMetier>>(utilisateurs);
    }
}