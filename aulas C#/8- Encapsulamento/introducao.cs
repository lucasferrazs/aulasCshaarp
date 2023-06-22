/*
O que é encapsulamento?
Encapsulamento é um dos pilares da programação orientada a objetos. 
Ele se refere ao conceito de agrupar dados e comportamentos relacionados
em uma única unidade (objeto) e controlar o acesso a esses dados e 
comportamentos. Encapsulamento permite ocultar os detalhes de 
implementação de um objeto e expor apenas uma interface pública,
tornando o código mais fácil de entender, manter e modificar. 
Isso também protege o estado interno do objeto e evita manipulações 
indesejadas ou corrupção de dados.

Modificadores de acesso (public, private, protected, internal)
Modificadores de acesso são usados para definir o nível de acesso 
aos membros de uma classe (propriedades, métodos, etc.). 
Eles ajudam a implementar o encapsulamento, controlando quais 
partes do código podem acessar esses membros.

public: O membro pode ser acessado por qualquer parte do código, 
dentro ou fora da classe, ou de outras classes e assemblies.

private: O membro só pode ser acessado dentro da própria classe.
Esse é o modificador de acesso padrão se nenhum outro for especificado.

protected: O membro pode ser acessado dentro da própria classe
e também por classes derivadas (herança).

internal: O membro pode ser acessado apenas dentro do assembly 
atual. Ele é útil quando você deseja expor um membro para outras 
classes no mesmo projeto, mas não para classes em projetos externos.


Getters e setters

Getters e setters são métodos que permitem controlar o acesso e a 
manipulação das propriedades de um objeto. Um getter é um método que 
retorna o valor de uma propriedade, enquanto um setter é um método que 
atribui um valor a uma propriedade.
*/
public class Exemplo
{
    private int _numero;

    // Getter
    public int GetNumero()
    {
        return _numero;
    }

    // Setter
    public void SetNumero(int valor)
    {
        if (valor >= 0)
        {
            _numero = valor;
        }
    }
}
/*
Propriedades (get e set)
Em C#, as propriedades são uma maneira mais elegante e conveniente de implementar
getters e setters. Elas permitem que você acesse e modifique os dados de um objeto
como se estivesse acessando uma variável pública, mas com a possibilidade 
de adicionar lógica personalizada para controlar o acesso e a manipulação dos dados.

*/
public class Exemplo
{
    private int _numero;

    public int Numero
    {
        // Getter
        get
        {
            return _numero;
        }
        // Setter
        set
        {
            if (value >= 0)
            {
                _numero = value;
            }
        }
    }
}

/*
As propriedades também podem ser simplificadas usando propriedades auto-implementadas, 
que geram automaticamente um campo privado para armazenar o valor da propriedade:
*/

public class Exemplo
{
    public int Numero { get; set; }
}
/*
No entanto, se você precisar adicionar lógica personalizada no getter ou setter,
você deve usar a sintaxe de propriedades completa mostrada anteriormente.
*/
