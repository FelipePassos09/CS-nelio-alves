<h1 style="color: purple; font-weight: bold;">Curso C# Completo</h1>
<h3>Prof. Nelio Alves (Udemy)</h3>
<h2>Detalhes do Curso</h2>
<p>O Curso compreenderá toda a trilah de conhecimento, do básico ao avançado, para desenvolvimento de software na linguagem C# na ótica da Programação Orientada á Objetos (POO).</p>
<h2>Aula 6 - C# e .NET</h2>
<p>
A distinção entre .net e c# pode ser descrita como o .NET sendo a familia de especificações e aplicações que compoẽm toda caracteristicas e desenvolvimento sobre essa tecnologia, isso envolve a linguagem (C#), a CLR (análoga à JVM do Java), as estruturas de portabilidade como o Xamarin, .NET Framework, .NET Core, etc...
<br />
Uma vez que a Estrutura do .NET é propietária da Microsoft há uma segmentação entre as variações de .NET possiveis, sendo elas:<br />
<table style="text-align:center">
    <tr>
        <td style="color: cyan;font-weight: bold;">.NET Framework</td>
        <td style="color: violet;font-weight: bold;">.NET Core</td>
        <td style="color: olive;font-weight: bold;">Xamarin</td>
        <td style="color: grey;font-weight: bold;">Mono</td>
    </tr>
    <tr>
        <td>Exclusivo para Windows</td>
        <td>Windows, Linux e Mac OS</td>
        <td>IOS, Android e Mac OS</td>
        <td>Vários</td>
    </tr>
    <tr>
        <td>Para Apps Windows Desktop e Web com ASP.NET rodando em IIS</td>
        <td>Aplicativos Console multiplataforma, web ASP.NET e serviços cloud</td>
        <td>Apps móveis híbridos (IOS e ANDROID) e para aplicações desktop para MacOS</td>
        <td>Aplicativos e jogos multiplataforma</td>
    </tr>
    <tr>
        <td>Possui as App Models: 
            <li>WPF</li>
            <li>Windows Forms</li>
            <li>Console</li>
            <li>ASP.NET</li>
        </td>
        <td>Possui as App Models: 
            <li>Console</li>
            <li>ASP.NET Core</li>
            <li>Recomendado Electron para interfaces desktop.</li>
        </td>
        <td>Possui as App Models: 
            <li>iOS</li>
            <li>MacOS</li>
            <li>Android</li>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>Base Libraries: <br />.Net Framework BCL</td>
        <td>Base Libraries: <br />.Net Core BCL</td>
        <td>Base Libraries: <br />Mono BCL</td>
        <td>Base Libraries: <br />Mono BCL</td>
    </tr>
</table>
</p>
<h2>Compilação e Interpretação</h2>
<p>
O C# é uma linguagem pré-compilada, ou seja, ela não é passivel de execução direta pelo computador, sendo necessário o uso de uma máquina virtual para que seja executado, processo análogo ao que ocorre com o Java. Diferente de uma linguagem compilada, ou seja, que o codigo fonte é compilado para um executável compatível com o sistema operacional onde será executado. As linguagens interpretadas atuam sem a necessidade de compilação, sendo, neste caso, executadas diretamente através de engines ou ambientes dedicados como o caso do Python, JavaScript e PHP.
</p>
<h2>Estrutura de uma aplicação .Net</h2>
<p>São basicamente formadas por classes, distribuídas/agrupadas por namespaces. Os namespaces consistem do agrupamento lógico de classes correlacionadas. Além dos namespaces temos os Assembly's que são o agrupamento de namespaces. Por fim temos a aplicação, que é o conjunto de todos os assemblys.<br />
Podemos ilustrar da seguinte forma:
    <ul>
        <li>Aplicação ou Solution
            <ul>
                <li>Assemblys ou Builds
                    <ul>
                        <li>Namespaces
                            <ul>
                                <li>Classes</li>
                            </ul>
                        </li>
                    </ul>
                </li>
            </ul>
        </li>
    </ul>
</p>
<h2>Estrutura dos Projetos</h2>
<p>
    <li>arquivo.csproj
        <ul>É o arquivo contendo os dados </ul>
    </li>
    <li>arquivo.cs
        <ul></ul>
    </li>
    <li>bin
        <ul></ul>
    </li>
    <li>
        <ul></ul>
    </li>
    <li>
        <ul></ul>
    </li>
    <li>
        <ul></ul>
    </li>
</p>
<h2>Estrutura do Código Fonte - Geral</h2>
<p>
<h3>Using System</h3>
<p>Referencia o uso de um namespace, no caso do System é um namespace original do .net. É a partir dele que podemos referenciar classes e funções provenientes de outros locais fora do nosso código principal.</p>
<h3>Namespace Projeto</h3>
<p>É a declaração de pertencimento à um namespace. É essa instrução que define para o código onde a classe será alocada. É opcional, mas fortemente indicado ser utilizado.</p>
<h3>Class</h3>
<p>É a definição da classe que será criada. Como a linguagem C# é orientada á objetos é necessaŕio que sempre criemos nosso código a partir de classes que podem, ou não, ser utilizadas por outros elementos a partir de instanciamento.</p>
<h3>static void Main (string[] args)</h3>
<p>Esta e a instrução que define o entry-point da nossa classe. Em outras palavras, é a instrução que declara o inicio de uma classe e sua execução, além de definir as variáveis e outros elementos que a classe irá receber ao longo da execução.</p>
<h3>{} - chaves</h3>
<p>São os delimitadores que permitem o encapsulamento dos elementos em um código fonte, a partir do uso deles podemos definir onde cada elemento começa e termina ou conteinerizar blocos de execução dentro de um elemento (como, por exemplo, em declarações lógicas como if/else ou do/while).</p>
</p>
<h2>Tipos Básicos C#</h2>
<p>
    <table style = "border: 1px solid">
        <tr style="font-weight: bold; font-size: 20px; text-align: center;color: darkgrey; font-weight:bold;">
            <td>C# Type</td>
            <td>.Net Framework Type</td>
            <td>Signed</td>
            <td>Bytes</td>
            <td>Possible Values</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">sbyte</td>
            <td>System.Sbyte</td>
            <td>Yes</td>
            <td>1</td>
            <td style="text-align: center">-128 to 127</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">short</td>
            <td>System.Int16</td>
            <td>Yes</td>
            <td>2</td>
            <td style="text-align: center">-32768 to 32767</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">int</td>
            <td>System.Int32</td>
            <td>Yes</td>
            <td>4</td>
            <td style="text-align: center">-2³¹ to 2³¹ -1</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">long</td>
            <td>System.Int64</td>
            <td>Yes</td>
            <td>8</td>
            <td style="text-align: center">-2⁶³ to 2⁶³ -1</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">byte</td>
            <td>System.Byte</td>
            <td>No</td>
            <td>1</td>
            <td style="text-align: center">0 to 255</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">ushort</td>
            <td>System.Uint16</td>
            <td>No</td>
            <td>2</td>
            <td style="text-align: center">0 to 65535</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">uint</td>
            <td>System.Uint32</td>
            <td>No</td>
            <td>4</td>
            <td style="text-align: center">0 to 2³² -1</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">ulong</td>
            <td>System.Uint64</td>
            <td>No</td>
            <td>8</td>
            <td style="text-align: center">0 to 2⁶⁴ -1</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">float</td>
            <td>System.Single</td>
            <td>Yes</td>
            <td>4</td>
            <td style="text-align: center">+/-1.5 x 10⁻⁴⁵ to +/- 3.4 x 10³⁸ with 7 significant figures.</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">double</td>
            <td>System.Double</td>
            <td>Yes</td>
            <td>8</td>
            <td style="text-align: center">+/-1.5x10⁻³²⁴ to +/-1.7x10³⁰⁸ with 15 or 16 significant figures.</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">decimal</td>
            <td>System.Decimal</td>
            <td>Yes</td>
            <td>12</td>
            <td style="text-align: center">+/-1.0x10⁻²⁸ to +/-7.9x10²⁸ with 28 or 29 significant figures.</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">char</td>
            <td>System.Char</td>
            <td>N/A</td>
            <td>2</td>
            <td style="text-align: center">Any Unicode character</td>
        </tr>
        <tr>
            <td style="color: purple; font-weight:bold; font-size:16px">bool</td>
            <td>System.Boolean</td>
            <td>N/A</td>
            <td>1/2</td>
            <td style="text-align: center">true or false</td>
        </tr>
    </table>

É muito importante observarmos os tipos básicos (primitivos) dos valores que iremos tratar em cada variável ou valor pois a partir deles podemos tanto otimizar o uso de memória como agilizar cálculos e evitar erros e bugs no código. O C# é uma linguagem fortemente tipada, ou seja, é essencial entendermos os tipos de cada valor e saber aplicá-los das melhores maneiras possiveis.

<h3>Principais Tipos</h3>
<h4>Int</h4>
<p>O tipo int(Integer) é destinado à definir valores inteiros, ou seja, valores sem casas decimais, tanto positivos quanto negativos.</p>
<h4>Short</h4>
<p>Assim como int, armazena apenas valores inteiros, positivos ou negativos, porém valores menores.</p>
<h4>Long</h4>
<p>Também como o Int, armazena valores inteiros, porém com dimensões maiores, necessaŕio para valores muito extensos. É aconselhável inserir um 'L' ao final do valor para identificar no código que este trata-se de um Long</p>
<h4>Bool / Boolean</h4>
<p>Esse tipo possui apenas dois valores, <a style="color: purple; font-weight:bold;">true</a> ou <a style="color: purple; font-weight:bold;">false</a>. No caso, esse tipo é destinado, principalmente, para definir valores lógicos de verdadeiro e falso.</p>
<h4>Char</h4>
<p>Aramzena caracteres Unicode, nesse caso podendo ser texto ou códigos unicode. É declarada utilizando aspas simples. Ex:<br />const char sexo:'F';<br />const char delta = '\u0394';</p>
<h4>Float</h4>
<p>São valores decimais, separados por ponto '.', para serem declarados é necessário passar, ao final do valor, o caracter 'f' para que seja interpretado como float ao invés de double. Possuem um interválo de valroes menor que o double porém ocupam menos butes em memória.</p>
<h4>Double</h4>
<p>São valores decimais, assim como o float, mas que possuem um intervalo maior de valores possiveis. No caso de double, ao ser declarado, basta ser informado um valor separado por ponto '.'.</p>
<h4>String</h4>
<p>É um tipo geral para texto e caracteres unicode, para ser declarada é necessário colocar os caracteres dentro de aspas duplas. Diferente do char, a string pode receber qualquer cadeia de caracteres. O tipo String não é, exatamente, um tpo primitivo. No caso da string, ela uma vez declarada se torna imutável, não podendo ser alterada por outros métodos no decorrer da execução.</p>
<h4>Object</h4>
<p>É o tipo de objeto genérico, é aplicada á qualquer objeto, inclusive classes. Sendo ele um tipo genérico ele pode assumir qualquer valor passad à ele, porém é importante observar seu uso pois pode gerar erros e bugs de execução ou tornar o código pesado ou inseguro.</p>
</p>
<h2>Declaração de Variáveis - Convenções</h2>
<p>
    <li>Não utilize nomes começando com números.
        <ul>Sempre inicie a variável usando uma letra ou um _(underline).</ul>
    </li>
    <li>Use camelCase.
        <ul>Utilize camelcase sempre que a variável possuir duas palavras.</ul>
    </li>
    <li>Não utilize espaços.
        <ul>Sempre que a variavel for composta insira uma palavra seguida da outra juntas.</ul>
    </li>
    <li>Evite a acentuação.
        <ul>Não utilize acentos, til, cedilha, etc, ao declarar variáveis, sempre insira apenas letras simples.</ul>
    </li>
    <li>Utilize nomes que possuam significado.
        <ul>Evite usar nomes genéricos ou pouco descritivos para declarar variáveis, desse modo a interpretação do código será mais simples.</ul>
    </li>

<h3>Convenções Camelcase</h3>
<p>Quando estamos desenvolvendo um software, principalmente quando estivermos desenvolvendo em POO (Programação Orientada a Objetos) é convencionado o uso de camelCase, no caso onde há a mescla entre letras maiúsculas e minúsculas no nome das variáveis. Nesse caso, em C# temos três formatos principais:
    <li>Camel Case
        <ul>Primeira palavra da viariável em letra minuscula, segunda palavra iniciando em letra maiúscula (ultimoNome). É utilizada geralmente para nomear métodos ou variáveis dentro de um método.</ul>
    </li>
    <li>Pascal Case
        <ul>Primeira e segunda palavras da variável começando com letra maiúscula (UltimoNome). Usada para namespaces, classes, properties e métodos.</ul>
    </li>
    <li>Padrão
        <ul>Mesma estrutura de Camel Case, porém iniciada sempre com underline (_ultimoNome). Usada em atributor internos da classe.</ul>
    </li>
<h3>Exemplo:</h3>
<textarea rows="19" cols="50">
    namespace Curso
    {
        class ContaBancaria
        {
            public string Titular { get; set; }
            private double _saldo;
            '
            public void Deposito(double quantia)
            {
                _saldo += quantia;
            }
            '
            public double GetSaldo()
            {
                return _saldo;
            }
        }
    }
</textarea>
</p>
<h2>Saída de Dados - Console</h2>
<p>
    Usamos as instruções do módulo Console: writeLine & write.
    <h3>writeLine</h3>
    <p>A entrada writeLine irá retornar o dado adicionando uma quebra de linha ao final.</p>
    <h3>write</h3>
    <p>Ira imprimir na tela o valor sem nenhuma quebra.</p>
Podemos utilizar formatação para algumas saídas com o módulo .ToString, passando como argumento um parâmetro de formatação como no caso de ou double, usando "F2" para imprmir dois decimais, ou mesmo, adicionando um outro namespace, formatar caracteres separadores a partir do FormatProvider, contido no namespace System.Globalization. Neste caso, após inserirmos o namespace podemos adicionar o parâmetro CultureInfo.InvariantCulture no .ToString para ignorar as regras de formatação.

<h3>Textos Compostos</h3>
<h4>Placeholders</h4>
<p>A partir de uma estrutura de coordenadas, podemos passar variáveis para serem impressas. Desse modo abrimos a string e, na posição onde cada variável será impressa, passamos uma coordenada numérica entre chaves, por fim, passamos as variáveis que serão impressas.</p>
<h4>Interpolação</h4>
<p>De modo semelhante ao que ocorre com os Placeholders, podemos passar as variáveis diretamente dentro das chaves, para isso basta iniciar a declaração por cifrão '$'.</p>
<h4>Concatenação</h4>
<p>Para este método usamos o operador '+' para indicar a inclusão os argumentos na string. Com a concatenação podemos, da mesma forma, mesclar variáveis e string estática.</p>
<h4>Formatando Saídas Concatenadas</h4>
<p>Quando dentro de uma string formatada usamos ':' e os parâmetros que definirão o formato da variável. Importante frisar que o padrão de separação de decimais é utilizando vírgula, nesse caso, caso queiramos alterar essa saída para vírgula é necessário utilizar o .ToString junto à variável.</p>
<h3>Exercício</h3>
<p>Em um programa inicie as variáevis contendo Computador, Mesa de Ecritório, uma idade qualquer, um código qualquer, um gênero, dois preços e uma medida (com mais de 4 decimais). Em seguida, usando os valores produza saidas contendo um preço pra computador, um preço para Mesa de Escritório, um registro de cliente com código, idade e sexo e, por fim, três formatos de saída para a medida, um sem alteração, um com menos casas decimais e um formatado com separador '.'.</p>
</p>
<h2>Operadores de Atribuição</h2>
<p>
    <li>=
        <ul>Representa "Recebe" e é usado para atribuir valores à variáevis, entre outros.</ul>
    </li>
    <li>+=
        <ul>Representa uma atribuição incremental, ou seja, reatribui o valor da váriavel como o valor dela mais o valor passado como incremento. Pode ser usado tanto com números quanto com strings, no caso de string ele concatena o valor da string com o que foi passado como argumento.</ul>
    </li>
    <li>-=
        <ul>Funciona como o anterior, porém na forma de decremento, ou seja, decrementa o valor a partir do que foi passado como argumento porém não opera com strings, apenas com números.</ul>
    </li>
    <li>++ / --
        <ul>Estes dois operadores irão funcionar, respectivamente, como incremento e decremento, porém apenas com uma unidade. Uma característica interessante desse operador é que, quando inserido depois da variável, em uma atribuição de valores, o valor da variável original é incrementado, porém a variável que reecbeu o valor não sofre incremento, quando passamos ele antes da variável, ambas recebem o valor incrementado.</ul>
    </li>
</p>
<h2>Conversão Implicita e Casting</h2>
<p>A conversão implicita ocorre quando passamos uma variável como atribuiçaõ de outra, de tipo diferente, mas que é compatível com a variável de destino. O Casting, ao contrário do anterior, é utilizado para atribuições de valores não compatíveis, nesse caso é necessaŕio passar o tipo do valor destino, entre parenteses, na declaração de atribuição.
<br />
Um detalhe importante é que, se fizermos operações com inteiros e queiramos o resultado como double, além de a variável que irá receber esse calculo ser do tipo double, precisamos passar o casting no dividendo pois, dessa maneira, o retorno será double também, do contrário o retorno será um inteiro truncado.
</p>
<h2>Operadores Aritiméticos Básicos</h2>
<p>
    <table style="border-collapse: collapse; border: 1px solid;">
        <tr style="font-weight: bold; font-size: 20px; text-align: center;color: purple; font-weight:bold;">
            <td>Operador</td>
            <td>Significado</td>
            <td>Descrição</td>
        </tr>
        <tr>
            <td style="font-weight: bold; font-size: 20px; text-align: center;color: darkgrey; font-weight:bold;">+</td>
            <td>Adição</td>
            <td>Representa a soma de dois valores ou concatenação caso um ou ambos sejam string.</td>
        </tr>
        <tr>
            <td style="font-weight: bold; font-size: 20px; text-align: center;color: darkgrey; font-weight:bold;">-</td>
            <td>Subtração</td>
            <td>Representa a diferença entre dois valores numéricos.</td>
        </tr>
        <tr>
            <td style="font-weight: bold; font-size: 20px; text-align: center;color: darkgrey; font-weight:bold;">*</td>
            <td>Multiplicação</td>
            <td>Representa o produto entre dois valores.</td>
        </tr>
        <tr>
            <td style="font-weight: bold; font-size: 20px; text-align: center;color: darkgrey; font-weight:bold;">/</td>
            <td>Divisão</td>
            <td>Representa o coeficiente de dois valores.</td>
        </tr>
        <tr>
            <td style="font-weight: bold; font-size: 20px; text-align: center;color: darkgrey; font-weight:bold;">%</td>
            <td>Resto da Divisão</td>
            <td>Retorna o resto caso a divisão não seja exata (se exata retorna 0)</td>
        </tr>
    </table>
    As precedências seguem iguais as da aritimética convencional, onde * e / são operadas antes de + e -. Para alterar o comportamento deve-se prestar atenção à organização de expressões ordenadas.
</p>
<h2>Entrada de Dados</h2>
<p>Para realizarmos a entrada de dados a partir do teclado utilizamos a isntrução <a style="color: purple; font-weight:bold;">Console.ReadLine</a>. Esta instrução, quando inserida, permite a leitura de um valor, desde a entrada padrão até o pressionamento do próximo enter. Importante ressaltar que o valor será lido, sempre, como string.</p>
<h2>Desmembrando Strings</h2>
<p>A partir de uma string podemos criar um vetor contendo os valores da string separados a partir do método .Split() e, como parâmetro, passamos o caractér ou conjunto de caracteres que serão usados para separar a string. Dessa forma o nosso vetor receberá os itens separados da string.</p>
<h2>Continuação - Entrada de Dados</h2>
<p>
    Conforme dito acima, a finção ReadLine sempre retornará uma string, portanto, para podermos lidar com números inseridos via teclado precisaremos usar a função de Parse, dessa maneira a entrada, quando identificada como número será convertida para o tipo inteiro, mas atenção, se o valor passado não for numérico, ou seja, uma string, um erro será lançado.
</p>