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
    Conforme dito acima, a função ReadLine sempre retornará uma string, portanto, para podermos lidar com outro tipos inseridos via teclado precisaremos usar a função de Parse, dessa maneira a entrada, quando identificada como número será convertida para o tipo inteiro, mas atenção, se o valor passado não for numérico, ou seja, uma string, um erro será lançado.
    <h3>.Parse()</h3>
    <p>A função .Parse é, na verdade, um módulo voltado à conversão de valores de string para outros tipos, nesse caso precisamos passar em primeiro lugar o tipo que queremos após a conversão, em seguida o módulo .Parse() e como parâmetro do parse a variável ou o próprio ReadLine.</p>
    <h3>Localização</h3>
    <p>Um ponto importante é lembrarmos que o .NET sempre levará em consideração a localização do computador com o qual está interagindo, nesse caso, quando passarmos um double, caso a máquina esteja em PT-br, por exemplo, não podemos usar o ponto como separador decimal, apenas a vírgula. Para contornarmos isso precisamos usar o módulo InvariantCulture para alterar o comportamento do separador (de vírgula para ponto).</p>
</p>
<h2>Exercício Proposto</h2>
<p>
    Faça um programa que realize a seguinte interação com o usuário, lendo valores na tela e mostrando as saídas corretamente formatadas:
    <br />
    <text style="color: purple;">Entre com seu nome completo:<br />Quantos quartos tem a sua casa:<br />Entre com o preço de um produto:<br />Entre seu último nome, idade e altura na mesma linha (separado por espaços):</text>

</p>
<h2>Operadores Comparativos</h2>
<p>
    Os operadores comparativos são usados para realizar análises e operações que retornam um bool, ou seja, retornam true ou false. Nesse caso temos os seguintes operadores:
    <ul>
        <li>>, <
            <ul>Significam "maior que" e "menor que", respectivamente. São utilizados quando queremos comparar dois valores e retornar se um é, realmente, maior ou menor que outro.</ul>
        </li>
        <li>>= , <=
            <ul>Significam "maior ou igual a" e "menor ou igual a" respectivamente. Usamos quando queremos analisar valores que podem ser iguais ou maiores/menores que o parâmetro passado.</ul>
        </li>
        <li>== , !=
            <ul>Significam "igual a" e "diferente de", respectivamente. São usados quando queremos comparar se um valor é igual ou diferente do parâmetro passado.</ul>
        </li>
    </ul>
</p>
<h2>Operadores Lógicos</h2>
<p>
    Assim como os comparativos, os operadores lógicos são usados quando estamos trabalhando com comparações. Nesse caso os operadores lógicos são empregados para podermos usar mais de uma condição ou negarmos alguma condição:
    <ul>
        <li>&&
            <ul>É usado para representar o 'E', ou seja, quando queremos adicionar mais condições à nossa comparação quem devem ser atendidas. No caso do 'E' uma comparação será verdadeira se somente todas as condições forem atendidas.</ul>
        </li>
    </ul>
    <ul>
        <li>||
            <ul>É usado para representar o 'OU', ou seja, quando queremos adicionar mais condições à nossa comparação, porém nem todas precisam ser atendidas. No caso do 'OU', basta uma das condições ser atendidas que o retorno será verdadeiro, somente será falso se todas forem falsas.</ul>
        </li>
    </ul>
    <ul>
        <li>!
            <ul>É usado para representar o 'NÃO', ou seja, para negar uma condição. O 'NÃO' é empregado para negar, ou seja, para inverter uma condição passada.</ul>
        </li>
    </ul>
    <p>A precedência entre os operadores é !(Não) > && (E) > || (Ou).</p>
</p>
<h2>Estruturas Condicionais</h2>
<p>
    <h3>Estrutura Simplificada</h3>
    <p>Usando a instrução if apenas para checar uma condição e executá-la se atendida.
    <textarea rows = 4 cols = 25>
    if ( condição ){
        comando 1
        comando 2
    }
    </textarea>
    </p>
    <h3>Estrutura Completa</h3>
    <p>Usando a instrução if para checar uma condição e executando uma instrução diferente com else caso ela não seja atendida. Cria dois possiveis caminhos para a execução.<br />
    <textarea rows = 8>
    if ( condição ) {
        comando 1
        comando 2
    }
    else {
        comando 1
        comando2
    }
    </textarea>
    </p>
    <h3>Estrutura Composta</h3>
    <p>Usando a instrução if para checar uma condição ou else if para checar outras condições possiveis, cada uma criando um desvio ou novo resultado e, por fim, else para executar uma instrução caso nenhuma anterior tenha sido atendida.<br />
    <textarea rows=15 cols = 30>
        if ( condição ) {
            comando 1
            comando 2
        }
        else if ( condição ) {
            comando 1
            comando 2
        }
        else if ( condição ) {
            comando 1
            comando 2
        }
        else {
            comando 1
            comando 2
        }
    </textarea>    
    </p>
</p>
<h2>Variáveis e Escopo de Inicialização</h2>
<p>Assim como nas demais linguagens, é essencial termos noção do escopo no qual iremos utilizar nossas variáveis</p>
<h2>Funções</h2>
<p>Representam um processamento que possuem um significado, ou seja, sempre executam a mesma ação e são reutilizáveis em essência. Além disso elas permitem a modularização do seu programa, o reaproveitamento e o encapsulamento. Além disso as funções podem receber dados de entrada e também possuir uma saída. No paradigma de orientação à objetos as funções,  quando em classes, são tratadas por 'métodos'.</p>
<p>Dentro do C#, no paradigma de orientação à objetos, a classe é composta por diversas funções, inclusive o entrypoint também é uma função. Para podemos declarar outras funções dentro de uma classe precisamos, fora do nosso 'Main", criar um novo método contendo o mesmo tipo de entrada (static) e passar o tipo de saída da função no lugar do void, em seguida inserimos, entre parentesis, as entradas que a função terá, definindo também o tipo e a variáevl que será utilizada pela função para referenciar este valor. É importante destacar que, assim como em outros momentos, o escopo das variáveis deve ser respeitado, ou seja, mesmo que passemos o mesmo nome de variável na função, essas serão novas variáveis pertencentes apenas à função definida. Assim como em outras linguagens, aqui podemos tanto ter uma saída em forma de valores a partir da instrução 'return'.</p>
No exemplo abaixo vemos uma função que realiza a soma entre dois números.<br />
<textarea cols="45" rows="10">
class Exemplo{
    public static void Main(string[] args){
        int num1;
        int num2;
        Console.WriteLine(Soma(num1, num2));
    }
    static int Soma(int var1, int var2){
        return var1 + var2;
    }
}
</textarea>
<h2>Debugging com Visual Code</h2>
<p>Para podermos realizar um degging utilizamos break-points para apontar pontos de parada na execução do nosso código, dessa maneira podemos controlar onde iremos pausar a execução do nosso programa para acompanharmos as ações. No ponto de parada ele irá começar a fazer o processamento passo a passo de acordo com as instruções abaixo:
<li>F5 - Inicia o debug.</li>
<li>F9 - Marca/desmarca o breakpoint na linha onde estiver o cursor.</li>
<li>F10 - Avança o debug para a próxima linha dentro do escopo local.</li>
<li>F11 - Avança o debug para o proximo passo, mesmo que saia do escopo local e entre em um módulo diferente.</li>
<li>Shift + F5 - Para o debug</li>
<li>Shift + F11 - Sai do método em execução e retorna para o escopo principal.</li>

<h3>Abas do Debugging</h3>
<p>
<li>Local - Mostra todas as variáveis e ações do escopo local.</li>
<li>Autos - Mostra as variáveis dos valores entendidos como relevantes pela IDE.</li>
</p>
</p>
<h2>Estruturas de Repetição</h2>
<p>
    <h3>While (enquanto)</h3>
    <p>Na estrutra enquanto executamos um loop baseado em uma condição lógica que, se atendida, para o loop e segue a execução do restante do código.</p>
    <h3>Do → While (faça + enquanto)</h3>
    <p>Diferente do while, a instrução do executa o loop mesmo que a condição ainda não tenha sido atendida, parando apenas quando ela for atendida, garantindo a execução de, pelo menos, uma repetição.</p>
    <h3>For (para)</h3>
    <p>de forma semelhante ao While, a instrução for define uma repetição do conteúdo de seu escopo, porém tal repetição é controlada a partir de uma condição previamente estabelecida, ou seja, aqui controlamos quantas vezes iremos repetir a instrução, diferente do que ocorre com o While.</p>
    <h3>For each (para cada)</h3>
    <p>A instrução 'for each' executa um loop baseado em uma lista ou série, nesse caso repetindo a execução tantas vezes quanto houverem valores na lista, ou série, apontada.</p>
</p>
<h1>Orientação à Objetos</h1>
<h2>Criando uma Classe</h2>
<p>Para criarmos uma classe precisamos, inicialmente, criar um arquivo de classe (.cs) e nele indicar as dependências, o namespace onde a classe estará alocada, o nome da classe, os atributos e o(s) métodos(s).</p>
<h2>Atributos</h2>
<p>Em resumo os atributos consistem nas características da nossa classe, eles quem irão definir o objeto invocado. É muito importante, então, termos bem estabelecidos atributos que serão utilizados.</p>
<h2>Métodos</h2>
<p>São as diversas aplicaçoões associadas a esta classe, no caso, ao criarmos uma nova classe, podemos indicar ações que ela pode efetuar a partir dos objetos criados como, por exemplo, uma operação matemática, uma saída em tela, um novo bloco de ações e etc. Uma maneira simples de definir um métod é que ele é uma função pertencente à classe onde está incluso.</p>
<h3>Características dos métodos</h3>
<li>Nome do Método - Consiste no nome do método que será usado para invocá-lo.</li>
<li>Parâmetros do Método - Consiste nos valores ou condições que precisam ser passadas no método para ser corretamente executado.</li>
<li>Corpo do Método - É o conteúdo do método, as instruções ou ações que ele irá executar e retornar quando invocado.</li>
<li>Tipo de saída - É o tipo de dado que será retornado do método.</li>
<h2>Prefixo Public</h2>
<p>O prefixo public é o indicativo que o atributo, classe ou método poderão ser acessados por outros arquivos dentro do namespace. Nesse caso, ao definirmos um dado como public, em todos os locais do namespace referenciado poderemos acessar esta classe e invocar seus métodos public.</p>
<h2>Static Members</h2>
<p></p>
<h2>Object and ToString</h2>
<p>Ao criarmos uma classe podemos definir, de maneira direta, qual a saída esperada caso o objeto instanciado seja chamado por alguma função. Para tanto podemos utilizar a função ToString, com sobrecarga, na classe criada, dessa maneira, ao chamarmos o objeto ele retornará uma string formatada tal qual configurarmos dentro da nossa classe. Isso é muito importante caso utilizarmos a classe para uma finalidade de registro ou mesmo de referenciação, por exemplo se nosso programa retornar em tela alguma característica da classe que precisemos. Outras aplicações dete método são caso queiramos criar um texto a partir da classe sem que para isso, façamos um método dedicado.</p>
<h2>Construtores</h2>
<p>Construtores são operações especiais de classe que executam no moneto da instanciação do objeto. São comumente usados para atribuição de valores específicos ou também permitir e/ou obrigar o uso de dependências no momento da instanciação.<br />Se não houver um construtor customizado a classe disponibiliza um construtor padrão (new). Além disso ainda á possivel especificar mais de um construtor na mesma classe a partir do uso de sobrecarga.</p>
<h2>Sobrecarga</h2>
<p>Em C# podemos definir a sobrecarga como um comportamento alternativo de um mesmo método ou atributo, ou seja, com ela podemos ter métodos de nomes iguais porém que se comportam de maneiras diferentes a depender dos atributos que são passados na chamada do método ou construtor. A sobrecarga é o principal elemento que define a caracterítica de polimorfismo da orientação à objetos.</p>
<h2>Alternativas à Inicialização de Valores</h2>
<p>Para instanciarmos um novo objetos podemos (e é recomendado) utilizar uma sintaxe alternativa à declaração de valores caracterizada pelo uso de chaves que recebem os atributos da classe de modo direto</p>
<h2>Palavra 'this'</h2>
<p>Em resumo, o 'this' é usado quando precisamos referenciar o próprio objeto instânciado dentro da classe, análogo ao 'self' em Python. Há diversos usos para a palavra reservada 'this', dentre eles os principais são:
    <li>Diferenciar atributos de variáveis locais.</li>
    <li>Referenciar outro construtor em um construtor.</li>
    <li>Passar o próprio objeto como argumento na chamada de um método ou construtor.</li>
</p>
<h2>Encapsulamento</h2>
<p>Consiste de uma característica onde escondemos os detalhes de uma implementação de modo a manter a acessíveis apenas informações seguras, desta forma mantendo o sistema consistente. O encapsulamento é feito utilizando-se dos métodos Get e Set, além do uso de 'private' em lugar de 'public'. O private garante que o método ou atributo não seja acessível diretamente de outro arquivo, ou seja, os valores e métodos não possam ser alterados diretamente. Por convenção, diferente dos atributos public, os atributos private são nomeados utilizando o "underline" no começo do nome e a primeira letra minúscula.</p>
<h2>Métodos Get & Set</h2>
<p>Consistem de meios para que os valores dos atributos de uma classe não possam ser alterados de modo implicito, ou seja, uma vez definidos os atributos private, caso queiramos alterá-los ou retorná-los, usamos os métodos Get(para retornar o valor de algum atributo) e Set (para alterar algum atributo). Dessa maneira podemos estabelecer meios de controle para o que, e como, algum método ou atributo podem ser acessados.</p>
<h2>Properties</h2>
<p>Consistem de métodos alternativos para o Get e Set onde, a partir de um método, podemos tanto definir o retorno de uma informação quanto quais dados serão aceitos para que seja alterada. Nas properties usamos as palavras reservadas 'get' e 'set' como parâmetros de retorno e entrada de dados, sendo, neste caso, funções internas do método. Além destes utilizamos a key 'value' como parâmetro de entrada do dado. Da mesma maneira que nos métodos Get e Set, caso não queiramos que um atributo seja alterado basta não implementar uma propertie com 'set', apenas 'get', dessa maneira poderemos retornar um valor sem, no entanto, podermos alterar este valor.</p>
<h3>Auto-Properties</h3>
<p>São uma alternativa mais simples e prática do uso das properties, neste caso consistem de uma maneira para definirmos de forma direta o get-set diretamente no atributo onde a própria sintaxe atribui os retornos do get e do set.</p>
<h2>Ordem Sugerida para implementação de membros</h2>
<p>
    <li>Atributos privados</li>
    <li>Propriedades autoimplementadas</li>
    <li>Construtores</li>
    <li>Propriedades customizadas</li>
    <li>Demais métodos da classe</li>
</p>
<h2>Modificadores de Acesso</h2>
<p>
Modificadores de acesso consistem de configurações nos métodos e atributos para limitar o acesso aos mesmos, neste caso podemos entender que são parâmetros inerentes à estes componentes que, de acordo com suas condições, permitem o acesso aos dados a partir de outros elementos do programa.
    <h3>Public</h3>
    <p>Trata-se do mais permissivo dos modificadores, permitindo o acesso incondicional e irrestrito por qualquer elemento do projeto.</p>
    <h3>Protected Internal</h3>
    <p>Permite o acesso para qualquer classe ou subclasse contanto que, sendo classe, esteja no mesmo projeto.</p>
    <h3>Internal</h3>
    <p>Permite o acesso para qualquer classe ou subclasse no mesmo projeto.</p>
    <h3>Protected</h3>
    <p>Permite o acesso apenas para para subclasses.</p>
    <h3>Private Protected</h3>
    <p>Permite o acesso apenas para subclasses do mesmo projeto.</p>
    <h3>Private</h3>
    <p>Permite o acesso apenas dentro da própria classe.</p>
    <table>
        <tr>
            <td style="font-weight: bold; color: purple;"></td>
            <td style="text-align: center;font-weight: bold; color: purple;">própria classe</td>
            <td style="text-align: center;font-weight: bold; color: purple;">subclasses no assembly</td>
            <td style="text-align: center;font-weight: bold; color: purple;">classes do assembly</td>
            <td style="text-align: center;font-weight: bold; color: purple;">subclasses fora do  assembly</td>
            <td style="text-align: center;font-weight: bold; color: purple;">classes fora do assembly</td>
        </tr>
        <tr>
            <td style="font-weight: bold; color: purple;">public</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
        </tr>
        <tr>
            <td style="font-weight: bold; color: purple;">protected internal</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;"></td>
        </tr>
        <tr>
            <td style="font-weight: bold; color: purple;">internal</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;"></td>
            <td style="text-align: center;"></td>
        </tr>
        <tr>
            <td style="font-weight: bold; color: purple;">protected</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;"></td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;"></td>
        </tr>
        <tr>
            <td style="font-weight: bold; color: purple;">private protected</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;"></td>
            <td style="text-align: center;"></td>
            <td style="text-align: center;"></td>
        </tr>
        <tr>
            <td style="font-weight: bold; color: purple;">private</td>
            <td style="text-align: center;">X</td>
            <td style="text-align: center;"></td>
            <td style="text-align: center;"></td>
            <td style="text-align: center;"></td>
            <td style="text-align: center;"></td>
        </tr>
    </table>
</p>
<h2>Modificadores de Acesso em Classes</h2>
<p>Para as classes temos também alguns modificadores, são eles:
    <h3>Public</h3>
    <p>Assim como nos membros, o acesso public permite o acesso incondicional à classe.</p>
    <h3>Internal</h3>
    <p>Assim como nos membros, este modificador permite apenas o acesso por classes dentro do mesmo assembly. Além disto, quando nenhum modificador é atribído à classe de forma explicita, o modificador internal é considerado como default (de modo implícito)</p>
    <h3>Private</h3>
    <p>Seguindo, o último modificador de classe é o private que define o acesso apenas a partir da classe mãe, ou seja, somente classes aninhadas são permitidas como private</p>
</p>
<h2>Exercício Proposto</h2>
<p>Criar um programa que crie uma conta bancária com número da conta, nome completo, condição se haverá ou não um primeiro depósito e, se positivo, um valor de depósito. Em seguida o programa irá solicitar um valor para depósito, então, será solicitado a realização de um saque (o saque terá uma taxa de $5,00).<br /><br />EM todas as ações os dados da conta e o valor na conta serão exibidos.</p>
<h1>Pnteiros</h1>
<p>Ao instanciarmos um objeto temos duas áreas criadas na memória da máquina, a Stack e Heap.</p>
<h3>Stack</h3>
<p>A stack pode ser tratada como uma referência à um espaço de memória que receberá os dados do objeto.</p>
<h3>Heap</h3>
<p>O Heap é o espaço na memória que receberá os dados da do objeto instanciado.</p>
<h2>Desalocação de Memória</h2>
<p>Quando estamos trabalhando com um código, temos todas as nossa variáveis e obejtos. Nesse caso todos estes elementos são alocados em memória. A desalocação da memória funciona para "limpar" da memória os dados alocados que não serão mais necessários no decorrer do programa.
<h3>Desalocação por Garbage Collector</h3>
<p>Nessa circunstância há a limpeza dos dados alocados sempre que um heap perde referencia com algum objeto ou variável. Nesse caso, sempre que temos algum valor que é referênciado por um ponteiro ou referência direta, assim que ele perde essa referência, seja por alteração do ponteiro ou da Stack onde o mesmo é referenciado o Garbage Collector realiza o despejo dessa alocação o mais breve possível.</p>
<h3>Desalocação por Escopo</h3>
<p>Ocorre quando o objeto ou variável está contida em algum escopo e este deixa de ser utilizado, nesse caso, assim que o programa sai do escopo que contém estes valores alocados o espaço respectivo na memória é desalocado imediatamente.</p>
</p>
<h2>Nullable</h2>
<p>Trata-se de um recurso onde o dado pode receber um valor nulo. Isso se faz necessário posis tipos valor são obrigatórios possuirem valor, para tanto podemos definir que variáevis destes tipos podem ser nulas através da instrução nullable, ou do operador '?' após o tipo da variável.
<h3>.HasValue</h3>
<p>O módulo irá retornar um boolean de acordo com a variável referênciada, retornará true caso o valor seja nulo ou false caso a variáevel contenha valor.</p>
<h3>.GetValueOrDefault</h3>
<p>Este módulo retorna o valor da variável ou um valor default para o tipo da variável em questão.</p>
<h3>.Value</h3>
<p>Por fim, o value retornará o valor da variável, porém se a variável for nula ele lançara uma exception informando que a variável é nula.</p>
</p>
<h2>Operador de Coalescência Nula [??]</h2>
<p>O operador de coalescência nula é usado para passar valores quando a variável indicada for nula. No caso ele faz uma análise rápida e aplica uma condição para que, se a varável for nula, ele aplique um valor (do mesmo tipo) indicado em seu lugar.</p>
<h1>Vetores</h1>
<p>Tratam-se de arranjos lineares, sequenciados, e que possuem elementos de mesmo tipo, também da-se o nome de 'array'. ALém dessas características um vetor possui estrutura ordenada, ou seja, cada elemento possui sua devida posição dentro do arranjo, além disso eles são alocados em um bloco único, contíguo, de memória. Uma desvantagem é que um array não possui possibilidade de incremento, ou seja, sempre será realocado integralmente em memória caso haja uma inclusão ou deleção de valor, outra desvantagem é a dificuldade de realizar alterações em um arranjo como este visto serem operações mais pesadas. Suas vantagens, no entanto, incluem a facilidade de se trafegar pelos valores, visto serem ordenados, e o fato de ele ser um bloco único de meória os dados ficam encapsulados dentro do arranjo, facilitando a localização deles dentro do programa.</p>
<h2>Manipulação de vetor <i>struct</i></h2>
<p>Para manipularmos um vetor do tipo struct basta indicar após o tipo que será um vetor usando abre e fecha colchetes e, como valor, passarmos um <i>new tipo</i> com a quantidade de posições dentro de colchetes. Apos isso incluímos novos valores informando em qual posição o valor será incrementado. </p>
<h2>Manipulação de vetor <i>classe</i></h2>
<p>Para criarmos um vetor do tipo classe usamos a mesma estratégia de uma struct, porém passando a classe ao invés do tipo. Nesse caso serão alocadas novas classes dentro deste vetor sendo cada posição um objeto diferente. Desse modo cada posição receberá todos os atributos do objeto individualmente, alocando os objetos separados. Para chamarmos um valor do objeto basta passarmos o vetor e posição mais o atributo desejado.</p>
<h2>Exercício Proposto - Apartamentos</h2>
<p>Um proprietário possui 10 apartamentos, sendo eles numerados de 0 a 9.<br /><br />Será necessário fazer um programa em que todos os quartos iniciem vazios e e cadaste os inquilinos com nome, e-mail, valor do aluguel e número do quarto. Depois de finalizado o cadastro o programa retorne um relatório com os dados de alugueis de todos os quartos ordenados por seu número.</p>