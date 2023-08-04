
using AppJogoDaForca.Models;

namespace AppJogoDaForca.Repository;

public class PalavrasRepository
{
    private readonly List<Palavras> _palavras;

    public PalavrasRepository()
    {
        _palavras = new List<Palavras>
        {
            new Palavras("Animais", "Gato"),
            new Palavras("Animais", "Cachorro"),
            new Palavras("Animais", "Elefante"),
            new Palavras("Animais", "Leao"),
            new Palavras("Animais", "Tigre"),
            new Palavras("Animais", "Zebra"),
            new Palavras("Animais", "Girafa"),
            new Palavras("Animais", "Panda"),
            new Palavras("Animais", "Macaco"),
            new Palavras("Animais", "Coelho"),
            new Palavras("Animais", "Rinoceronte"),
            new Palavras("Animais", "Hipopotamo"),
            new Palavras("Animais", "Cavalo"),
            new Palavras("Animais", "Urso"),
            new Palavras("Animais", "Camelo"),
            new Palavras("Animais", "Cobra"),
            new Palavras("Animais", "Pinguim"),
            new Palavras("Animais", "Avestruz"),
            new Palavras("Animais", "Gorila"),
            new Palavras("Animais", "Peixe"),

            // Tipo: Cores
            new Palavras("Cores", "Vermelho"),
            new Palavras("Cores", "Azul"),
            new Palavras("Cores", "Verde"),
            new Palavras("Cores", "Amarelo"),
            new Palavras("Cores", "Roxo"),
            new Palavras("Cores", "Laranja"),
            new Palavras("Cores", "Preto"),
            new Palavras("Cores", "Branco"),
            new Palavras("Cores", "Rosa"),
            new Palavras("Cores", "Marrom"),
            new Palavras("Cores", "Cinza"),
            new Palavras("Cores", "Dourado"),
            new Palavras("Cores", "Prateado"),
            new Palavras("Cores", "Turquesa"),
            new Palavras("Cores", "Ciano"),
            new Palavras("Cores", "Magenta"),
            new Palavras("Cores", "Verde-azulado"),
            new Palavras("Cores", "Bege"),
            new Palavras("Cores", "Rubi"),
            new Palavras("Cores", "Ametista"),

            // Tipo: Países
            new Palavras("Países", "Brasil"),
            new Palavras("Países", "Estados Unidos"),
            new Palavras("Países", "Canada"),
            new Palavras("Países", "Japao"),
            new Palavras("Países", "Australia"),
            new Palavras("Países", "China"),
            new Palavras("Países", "Alemanha"),
            new Palavras("Países", "Italia"),
            new Palavras("Países", "India"),
            new Palavras("Países", "Mexico"),
            new Palavras("Países", "Franca"),
            new Palavras("Países", "Espanha"),
            new Palavras("Países", "Russia"),
            new Palavras("Países", "Argentina"),
            new Palavras("Países", "Africa do Sul"),
            new Palavras("Países", "Coreia do Sul"),
            new Palavras("Países", "Canada"),
            new Palavras("Países", "Suecia"),
            new Palavras("Países", "Suica"),
            new Palavras("Países", "Portugal"),

             // Tipo: Profissões
            new Palavras("Profissões", "Medico"),
            new Palavras("Profissões", "Professor"),
            new Palavras("Profissões", "Engenheiro"),
            new Palavras("Profissões", "Advogado"),
            new Palavras("Profissões", "Artista"),
            new Palavras("Profissões", "Policial"),
            new Palavras("Profissões", "Arquiteto"),
            new Palavras("Profissões", "Cientista"),
            new Palavras("Profissões", "Empresario"),
            new Palavras("Profissões", "Veterinario"),
            new Palavras("Profissões", "Piloto"),
            new Palavras("Profissões", "Bombeiro"),
            new Palavras("Profissões", "Jornalista"),
            new Palavras("Profissões", "Cozinheiro"),
            new Palavras("Profissões", "Designer")
        };
    }
    public Palavras GetWordRandom()
    {
        Random random = new Random();
        var num = random.Next(0, _palavras.Count);

        return _palavras[num];
    }
}
