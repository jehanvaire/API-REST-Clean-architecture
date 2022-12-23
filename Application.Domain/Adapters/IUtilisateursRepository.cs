using Application.Domain.Models;

namespace Application.Domain.Interfaces;

public interface IUtilisateursRepository
{
    public List<UtilisateurMetier> GetUtilisateurs();
}