namespace API_REST_MVC.Models;

public class UtilisateurMessage
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Email { get; set; }
    public DateTime DateNaissance { get; set; }
}