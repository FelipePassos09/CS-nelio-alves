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
<h2>Modificadores de Parâmetros params</h2>
<p>Os modificadores de parâmetros podem ser usados para, entre outras coisas, definir do modo dinâmico a alocação de parâmetros de uma função. Nesse caso inserimos o 'params' no ínicio dos nossos parâmetros, desse modo basta informarmos os parâmetros a serem considerados que haverá a alocação implicita dos mesmos dentro da função.</p>
<h2>Modificadores ref e out</h2>
<h3><i>ref</i></h3>
<p>O modificador ref serve para indicar que a função irá alterar o valor da variável informada. Nesse caso quando associamos a instrução ref, uma vez que passemos uma variável dentro de um método, a saída desse método irá alterar o valor da variável de acordo com a proposta da variável.<b>Neste caso a variável precisa ser previamente iniciada para que seja aceita no parâmetro</b></p>
<h3><i>out</i></h3>
<p>Já a instrução out irá criar uma variável a partir dos parâmetros passados, nesse caso, passamos uma variável de entrada e, como parâmetro, dizemos qual o nome da variável de saída. Nesse caso, após a execução do método, podemos chamar a variável de saída diretamente. <b>Diferente do modificador ref, neste caso nossa variável não precisa ter sido previeamente iniciada.</b></p>
<p>Uma observação importante é que, ambas as instruções (ref e out) devem ser evitadas na criação de um programa moderno. Essas instruções são, na prática, vestígios da integração entre C# e C++, uma vez que em C++ há a declaração de variáveis explicitas, algo que não ocorre no C#.</p>
<h2>Boxing & Unboxing</h2>
<h3>Boxing</h3>
<p>O boxing consiste no uso do "tipo" Object para declaração de uma variável. Este tipo trata-se de uma classe sendo que, nesse caso, ele cria um apontamento direto com o heap, não havendo uma stack propriamente dita. Na prática este tipo aceita qualquer valor, porém isso gera um custo de processamento uma vez que é necessário buscar no heap cada novo uso dessa variável.</p>
<h3>Unboxing</h3>
<p>É o processo inverso do boxing, nesse método criamos uma variável com tipo definido que irá trazer para o stack o valor contido no heap. Dessa maneira, cada chamada do novo objeto será menos onerosa para a performance do programa.</p>
<h1>Listas PT1</h1>
<p>Nota: depende da lib System.Collections.Generic</p>
<h2>Conceito de Lista</h2>
<p>Consiste de uma estrutura de dados homogênea, ordenada, inicia vazia e seus elementos são alocados sob demanda e cada elemento ocupa um nó.<br /><br />Para inciarmos uma lista passamos a instrução 'List<tipo>' onde informamos o tipo de dado que a lista contera entre <>, em seguida iniciamos a lista com new List<>(). Essa declaração nos permite, inclusive, declarar uma lista sem iniciá-la, diferente do que ocorre com os vetores que precisam do seu tamanho previamente definido. Outra maneira de se declarar uma lista é substituir os parentesis por chaves e passar os valores entre as chaves, este modo de declaração irá além de alocar um novo objeto de lista, iniciar seu conteúdo.
    <h3>Trabalhando com Listas - Métodos</h3>
        <h4>Inserir elementos na lista</h4>
            <li>.Add - Adiciona um elemento ao final da lista.</li>
            <li>.Insert - Adiciona um valor na posição indicada. Nesse caso ele irá inserir o valor na posição indicada e empurrar o restante dos itens para frente.</li>
        <h4>Extratindo o tamanho da lista</h4>
            <li>.Count - Irá retornar o tamanho da lista, ou seja, a contagem de todos os seus itens instanciados.</li>
        <h4>Encontrar primeiro ou último <b>item</b> que satisfaça um predicado</h4>
            <li>.Find - retorna a primeira ocorrência de um item a partir de uma função ou predicado (lambda).</li>
            <li>.FindLast - retorna a última ocorrência de um item a partir de uma função ou predicado (lambda).</li>
        <h4>Encontrar primeiro ou último <b>posição</b> que satisfaça um predicado</h4>
            <li>.FindIndex - com a mesma sintaxe do .Find, este método retorna a posição do primeiro item que coincide com o predicado.</li>
            <li>.FindLastIndex - com a mesma sintaxe do .Find, este método retorna a posição do último item que coincide com o predicado.</li>
        <h4>Filtrar uma lista com base em um predicado</h4>
            <li>.FindAll - a partir de um predicado podemos criar uma nova lista contendo apenas os items aderentes à um predicado.</li>
        <h4>Remover itens de uma lista</h4>
            <li>.Remove - recebe um parâmetro e remove os itens que seja iguais à este parâmetro.</li>
            <li>.RemoveAll - o RemoveAll recebe um prediacdo e remove todos os itens que coincidam com o predicado.</li>
            <li>.RemoveAt - remove um item a partir de sua posição.</li>
            <li>.RemoveRange - remove os itens da lista a partir de sua posição, mas neste caso passamos quantos itens serão removidos a partir dessa posição.</li>
</p>
<h2>Generics</h2>
<p></p>
<h2>Predicados (lambda)</h2>
<p>Trata-se de uma função que, a partir de um valor, retorna true ou false. Pode-se dizer, no entanto, que neste caso usamos uma sintaxe resumida para essa declaração e esta função não pode ser invocada ou reutilizada, sendo, portanto, uma função anônima.
    exemplo:
    <p>
        static void Test(string s)<br />{<br /> return s[0] == 'A';<br />}
    </p>
    pode ser tratado como:
    <p>
        ...(s => s[0] == 'A');
    </p>
</p>
<h2>Exercício de Fixação: Listas</h2>
<p>Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salário) de N funcionários. Não deve haver repetição de id.<br />Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. Para isso o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários, conforme os exemplos.<br />Lembre-se de aplicar a técnica de encapsulamento para que o salário não possa ser alterado livremente. Um salário só pode ser alterado com base em uma operação de aumento por porcentagem dada.</p>
<h1>Matrizes</h1>
<h3>Teoria Sobre Matrizes</h3>
<p>Trata-se de um arranjo bidirecional de valores, ou seja, possuem colunas e linhas. <br />Assim como vetores, matrizes possuem tamanhos fixos, são dificeis de se incluir e remover valores, e precisam ser previamente instanciadas já com seu tamanho. Além disso, assim como nos vetores, as matrizes possuem um tipo único de dados que poderão armazenar.</p>
<h2>Trabalhando com Matrizes</h2>
<p>Assim como nos vetores, declaramos uma matriz inciando-a com o tipo de dado que ela irá armazenar, porém, como dito anteriormente, a matriz possui duas dimensões e, neste caso, passamos a quantidade de linhas como o primeiro valor dentro dos colchetes, e a quantidade de colunas como o segundo valor: new double[2,3].</p>
<h3>.Length</h3>
<p>Assim como em uma lista ou vetor, também podemos obter a contagem de itens de uma matriz a partir do método .Length. Geralmente a quantidade de itens será o produto entre linhas e colunas.</p>
<h3>.Rank</h3>
<p>Este método permite recuperarmos a quantidade de linhas desta matriz.</p>
<h3>.GetLength</h3>
<p>Este método retornará a quantidade de linhas quando passado o parâmetro 0, e a quantidade de colunas quando passado o parâmetro 1.</p>
<h2>Exercicio de fixação: Matrizes</h2>
<p>Fazer um programa para ler dois números inteiros (M e N) e depois criar uma matriz de M linhas por N colunas contendo números inteiros. Em seguida ler um número inteiro X que pertence à matriz. Para cada ocorrência de X mostrar os valores acima, à esquerda, à direita e abaixo de X, quando houver, conforme exemplo:
<br/><br />
<a href="https://github.com/acenelio/matrix2-csharp">Link do cód.</a>
</p>
<h1>Tópicos Especiais - Pt 1</h1>
<h2>var - inferencia de tipos</h2>
<p>A palavra 'var' pode ser utilizada em lugar da entrada do tipo, neste caso o compilador irá inferir, ou seja, aplicar, o tipo condizente com o valor passado à variável quando a mesma for iniciada. Neste caso podemos usá-la, virtualmente, para todos os tipos de dado, porém isso pode gerar problemas na execução do código pois deixa brechas para que um valor que nãos seja condizente com o tipo seja aplicado à variável.</p>
<h2>Sintaxe alternativa - switch-case</h2>
<p>É utilizado para se substituir uma sequência padronizada e encadeada de ifs, neste caso podemos, através do switch-case inserir passar a variável que queremos avaliar e, como cases, o que será realizado para cada valor que esta variável possua. Além disso, podemos (e é indicado) passar um valor padrão para a saída do loop. Temos, também, que finalizar o retorno de cada case com 'break', desse modo haverá a correta saída do loop.</p>
<h2>Sintaxe Alternativa - Expressão condicional ternária</h2>
<p>Podemos escrever um conjunto if-else de modo diferente, mais economico. Nesse caso passamos a nossa condição entre parentesis e as saídas quando true ou false, após á condição. Definimos o valor que será a saída quando true colocando-o após um ponto de interrogação ('?'), e o valor falso colocando-o após dois pontos (':'). Para essa operação precisamos atribuí-la como valor para uma variável, neste caso ela retornara o valor da variável diretamente, sem a necessidade de passarmos instruções alternativas (if e else) para atribuição deste valor.</p>
<h2>Trabalhando e tratando strings</h2>
<h3>.ToUpper</h3>
<p>O método .ToUpper irá transformar todos os caracterese de uma string para maiúsculo.</p>
<h3>.ToLower</h3>
<p>Ao contrario do ToUpper, o ToLower irá transformar toda a string em minúscula.</p>
<h3>.Trim</h3>
<p>O método .Trim irá 'limpar' a string, ou seja, irá remover os espaços em branco antes e depois da string. Desse modo o primeiro e último caracteres válidos serão considerados para definir o começo e final da string.</p>
<h3>.IndexOf</h3>
<p>Irá retornar a primeira posição onde o caracter, ou a sequência de caracteres passada ocorre. Neste caso, caso seja uma sequencia, irá retornar a posição do primeiro carácter da sequencia na string.</p>
<h3>.LastIndexOf</h3>
<p>Ao contrário do método anterior, este método retorna a última posição de um caracter ou sequencia de caracteres. seguinda a mesma lógica para o primeir caracter coincidente da sequência.</p>
<h3>.Substring</h3>
<p>O método Substring retorna uma nova string com um pedaço da string associada. Este método possui as duas sobrecargas abaixo:
    <h4>A partir do índice inicial apenas</h4>
        <p>Irá retornar uma nova string a partir do índice passado, neste caso retornando todos os caracteres.</p>
    <h4>A partir do índice e comprimento</h4>
        <p>Esta sobrecarga adiciona a quantidade de posições que será retornada do método</p>
</p>
<h3>.Replace</h3>
<p>É destinado á substituir caracteres de uma string, neste caso gerando uma nova string alterada. Possui algumas sobrecargas:
    <h4>Usando o caractere buscado e o substituto [CHAR]</h4>
        <p>Podemos, neste caso, passar o caractere que será substituído e o que entrará em seu lugar. Neste caso o método recebe os parâmetro como CHAR (aspas simples).</p>
    <h4>Substituindo uma série de caracteres [STRING]</h4>
        <p>Neste caso podemos usar strings como parâmetros, onde o método irá localizar a string do parâmetro dentro do objeto associado e substituí-la pela outra que foi passada.</p>
</p>
<h2>.IsNullOrEmpty</h2>
<p>Este método avalia a string e retorna um booleano com a checagem se ela é, ou não, vazia.
    <h4>String nula</h4>
        <p>Trata-se de uma variável string sem um valor associado.</p>
    <h4>String vazia</h4>
        <p>Trata-se de uma string sem caracteres, ou seja, apenas com as aspas abertas e efchadas. (Neste caso o espaço conta como um caractere.)</p>
</p>
<h2>.IsNullOrWhiteSpace</h2>
<p>Este método retorna um booleano checando se a string é nula ou se é apenas um conjunto de espaços, ou seja, não possui caracteres.</p>

<h2>Trabalhando com DateTime</h2>
    <p>O objeto datetime trata-se de um valor armazenado de ticks, ou seja, um total de 100 nanosegundos para cada tick, contados a partir do momento 0 da era atual. Ou seja, esse objeto pode representar qualquer modelo e/ou formato de data conhecido uma vez que seu valor real é um timestamp e não um valor absoluto.
    <br /><br />
    Outro detalhe acerca de datetimes é que eles são instanciados como um novo objeto, ou seja, sua declaração é feita da seguinte maneira:<br /><br />DateTime var = new DateTime(yyyy, MM, dd, HH, mm, ss, kind)<br />Cada parâmetro do novo objeto representa um totalizador e, no parâmetro kind, podemos definir o fuso-horário que será considerado para este objeto.É importante salientar que todos os parâmetros preciam receber valores integers.
    </p>
    <h3>Builders</h3>
    <p>
        Tratam-se de métodos do objeto DateTime onde podemos criar um objeto sem, necessáriamente, informarmos valores para este.
        <h4>.Now</h4>
            <p>Cria um objeto DateTime com a data e horário do momento de sua invocação, considerando o kind da máquina.</p>
        <h4>.Today</h4>
            <p>Cria um objeto DateTime com a data atual, mas horário 00:00:00, ou seja, inferindo o valor apenas da data, e não das horas.</p>
        <h4>.UtcNow</h4>
            <p>Análogo ao .Now, porém este cria o valor considerando o fuso-horário 0, ou GMT.</p>
    </p>
    <h3>.Parse()</h3>
        <p>O método .Parse permite instanciarmos um objeto DateTime utilizando como parâmetro uma string. Neste cenário ele irá ler a string e transformá-la em um objeto DateTime contendo o seu respectivo valor. Atenção, este formato busca por layouts padronizados de data, então alguns formatos podem não ser reconhecidos.</p>
    <h3>.ParseExact()</h3>
        <p>Assim como o .Parse, este método também analisa uma string e retorna um objeto DateTime, porém este método permite que passemos qualquer formato desejado e, em um segundo parãmetro, o formato que deverá ser reconhecido. Por exemplo, ao passarmos a data "25/03/21", passamos o seguinte formato: "dd/MM/yy", desta forma o código conseguirá reconhecer os valores em cada um dos argumentos.</p>
<h2>TimeSpan => Duração</h2>
    <p>O objeto TimeSpan tem por objetivo apresentar durações, ou seja, usa de valores em ticks para representar intervalos de tempo. Para tanto ao declaramos um novo TimeSpan podemos usar seu construtor padrão, informando os valores de dias, horas, minutos e segundos ou, também, usar um valor em ticks para recuprear este valor. A sua saída será um valor formatado tal qual d.HH:mm:ss.</p>
    <h3>Métodos From</h3>
        <p>Os métodos From permitem conversarmos com o TimeSpan em unidades inteiras, por exemplo, usando um FromDays e passando o valor 1.5 como atributo, temos o retorno de um TimeSpan contendo o valor 1.12:00:00. Isso é muito imporante para tranalharmos com durações mais resumidas ou em escalas maiores, sem a necessidade de utilizarmos diretamente os totais de ticks.
            <ul>
                <li>.FromDays - Permite criarmos um TimeSpan a partir do totalizador de dias.</li>
                <li>.FromHours - Permite criarmos um TimeSpan a partir do totalizador de horas.</li>
                <li>.FromMinutes - Permite criarmos um TimeSpan a partir do totalizador de minutos.</li>
                <li>.FromSeconds - Permite criarmos um TimeSpan a partir do totalizador de segundos.</li>
                <li>.FromMilliseconds - Permite criarmos um TimeSpan a partir do totalizador de milissegundos.</li>
                <li>.FromTicks - Permite criarmos um TimeSpan a partir do totalizador de ticks, neste caso precisamos passar o 'L' ao final do número de ticks para indicar se tratar de um long.</li>
            </ul>
        </p>
<h2>Nivelamento GIT + Github</h2>
<p>
    Para fins de nivelamento alguns conteúdos serão abordados, as prioncipais anotações e pontos de interesse irei comentar aqui:
    <h3>Git Init</h3>
        <p>Comando usado para criação de um repositório local, nesse sentido, o repósitório local é um conjunto de arquivos que serão versionados no repositorio remoto (remote).</p>
    <h3>Git Commit</h3>
        <p>Um commit se resume em uma versão do código desenvolvido, no commit são gravadas as alterações realizadas no código, de modo que, a partir de seu registro, possamos retornar ao estado anterior à alterações de maneira simples e controlada. Em paralelo, um commit também serve para controlarmos o estado de desenvolvimento e os incrementos realizados.</p>
    <h3>Git Add</h3>
        <p>Usado para serem inclusos os arquivos que serão commitados, ou seja, com ele listamos os arquivos que iremos atualizar neste commit e enviamos os mesmos para a área de stage para que façamos o commit, podendo ser todos os arquivos editados.</p>
    <h3>Git Pull, Push, Clone</h3>
        <p>São instruções de incremento ou atualização dos dados entre o repositório local e o remoto:
            <ul>
                <li>Clone: Usado para fazermos uma cópia local dos dados armazenados no repositório remoto.</li>
                <li>Pull: Usado para retornarmos, a partir do repositório remoto, as alterações mais recentes.</li>
                <li>Push: Usado para enviar ao remote os commits já criados a partir das alterações no repositório local.</li>
            </ul>
        </p>
    <h3>Git Status</h3>
        <p>Usado para vermos os status das atuais alterações e/ou atualizações nos arquivos do repositório local. Em resumo ele retorna o status das alterações em stage, ou seja, ainda não commitadas.</p>
    <h3>Git Reset</h3>
        <p>Usado para limparmos o stage, ou seja, excluirmos os registros de alterações realizados antes de fazermos o commit.</p>
    <h3>Git Branch</h3>
        <p>Usado para criar uma nova branch no nosso repositório.</p>
    <h3>Git Add remote</h3>
        <p>Usado para endereçar o nosso repositório, ou seja, gravar o endereço do repositorio, seja no guthub, bitbucket ou outro.</p>
    <h3>Git Checkout</h3>
        <p>Usado para voltar, ou posicionar, o nosso repositório em uma release anterior, isso é importante para podermos checar ou testar alguma alteração prévia. <b>Muito importante: quando estivermos dentro de um checkout fora da nossa branch principal devemos evitar alterações nos aqruivos, assim como devemos, também, nos certificarmos de termos limpado toda a stage antes de voltarmos para a branch principal, do contrário essa alterações podem ficar perdidas ou alterar os arquivos da branch gerando problemas para o código.</b></p>
    <h3>Outras Funcionalidades do Git</h3>
        <p>Além de criarmos e atualizarmos os repositórios, com o Git podemos também manipular os arquivos a partir do remote, de modo que possamo navegar entre as versões e atualizarmos nosso projeto em relação às mesmas. Isso é um facilitador no dia a dia, porém pode gerar alguns conflitos conforme abaixo:
            <h4>Conflito de Pull por Históricos Diferentes</h4>
                <p>Esse conflito ocorre em casos onde o repositório local não está atualizado em relação ao remote e há algum commit que não foi sincronizado. Nesse caso podemos fazer um Pull para atualizar o nosso projeto e, em seguida, refazer o push com o nosso commit. <b>Importante: Esse método somente é permitido nos casos onde o commit faltante não envolvia o arquivo alterado.</b></p>
            <h4>Conflito de Pull por Merge de Três Vias</h4>
                <p>Isso ocorre quando o seu commit envolve algum arquivo que sofreu alteração recente e o commit não foi sincronizado no seu repositório local. Nesse caso podemos fazer um pull e, então, decidir quais alterações serão mantidas. Após fazermos as correções, fazemos um novo commit, enviamos as alterações novamente para o Stage e fazemo um push definitivo atualizando o remote.</p>
            <h4>Sobrescrevendo Históricos</h4>
                <p>Caso queiramos descartar e excluir commits, podemos fazer um git reset --hard ,cód. commit> e, desta forma, iremos fazer um rollback do nosso repositório até o commit selecionado.<b>Importante: Essa ação descarta todos os históricos e incrementos de forma definitiva, após executada não é possível voltar com os incrementos.</b></p>
        </p>
</p>
<h1>Intermediário</h1>
    <h2>Enumerações e Composição</h2>
        <p>Aqui iremos aprender a definir as durações de cada objeto, como compor objetos.</p>
    <h2>Tipos Enumerados</h2>
        <p>
            <h3>Definição</h3>
                <p>Uma Enumeração é um componente básico, criado a partir de um mapping contendo Valores e Chaves, nesse caso uma enumeração serve como um dicionário de valores possíveis para um atributo ou valor contido dentro de um objeto.</p>
            <h3>Exemplo</h3>
                <p>Diretório Entities, Classe Order <br/>Diretório / Projeto: ./RascunhosDiversos/RascunhosDiversos.sln</p>
            <h3>Trabalhando com Enums</h3>
                <p>Para trabalharmos com enumerações temos diversas maneiras, porém a melhor prática é criarmos dentro do diretório que conterá as classes, um segundo sub-diretório contendo todas as enumerações. Deste modo tudo ficará oprdenado e melhor distribuído dentro da aplicação.
                <br/><br/>
                Para declararmos uma enumeração basta criarmos uma nova classe e declararmos a enumeração no lugar da classe, nesse caso substituindo, também, a instrução class por enum.
                </p>
            <h3>UML com Enums</h3>
                <p>Para declararmos uma enum dentro do diagrama de UML precisamos passar o estereótipo desta entidade dentro do bloco no qual ela será definida. Para declararmos um estereótipo basta usar um conjunto de dois < + dois > envolvendo a palavra Enum. Uma outra coisa importante é passarmo o estereótipo dentro dos valores desta entidade, e também definir dentro da classe onde essa enum for utilizada, no valor que será atribuído pelo enum, que o mesmo trata-se de uma enumeração.</p>
        </p>
    <h2>Design</h2>
        <p>Em uma arquitetura orientada à objetos devemos partir do princípio que tudo será um objeto, neste caso tendo suas classes associadas, portanto é importante levarmos em conta a definição de categorias das classes para facilitar a organização, flexibilidade, reuso, manutenção, delegação e etc, neste caso havendo várias categorias de classes.
            <ul>
                <li>Entities</li>
                <li>Controllers</li>
                <li>Services</li>
                <li>Views</li>
                <li>Repositories</li>
                <li>Tools</li>
            </ul>
        <h3>Entities</h3>
            <p>Uma entitie se resume por uma parcela do negócio cujo sistema trata, de forma geral, são pedaços do produto alvo da solução. Por exemplo, para um sistema de vendas temos as entidades como pedidos, clientes, produtos, etc; já para um sistema de logítica as entidades podem ser as rotas, veículos, motoristas, pacotes, etc.</p>
        <h3>Services</h3>
            <p>São os serviços feitos pelo sistema, ou seja, as interações que o sistema executa, seja entre entidades ou com aplicações externas como envio de e-mails ou consulta e gravação de informações no banco de dados.</p>
        </p>
<h2>Composição</h2>
    <p>
    Tratamos por composição uma estrutura de distribuição de objetos onde é permito que um objeto contenha outro em si, ela pode possur tanto a relação "tem um" como a relação "tem vários".
        <br/><br/>
    A composição nos traz várias vantagens como uma melhor organização dos componentes, maior coesão do código, maior flexibilidade visto podermos distribuir de modo mais fragmentado os componentes e o reuso visto que com uma maior flexibilidade podemos adaptar a aplicação de componentes com poucas alterações.
    </p>
    <p><b>Nota:</b> embora o simbolo UML para composição seja o diamante preto, no nosso caso ele irá representar tanto uma composição tem um quanto tem vários, ou seja, o todo parte será distribuído a partir do mesmo nó caso hajam interdependências de composição.</p>
    <p>Durante uma composição podemos referenciar tanto objetos interligados quanto módulos destes, dessa maneira podemos compartimentar e orquestrar melhor os componentes.</p>
<h2>Herança</h2>
    <p>Entende-se por herança o comportamento pelo qual permitimos que uma classe herde dados e comportamentos de outra atrvés de um processo de associação.
    <br/>
    Geralmente usamos o mecanismo de herança para estender os métodos e dados de uma classe, ou, por vezes, um método, para outra, sendo para isto utilizado o caractér de ':' (dois pontos) para  indicar que estará sendo feita esta extensão.
    <br/>
    Uma das principais aplicações de herança é a possibilidade de modularização e reutilização de código, 
    </p>
    <p>Dentro de uma associação por herança temos uma distinção quanto à uma associação por composição onde, no caso da herança, associamos uma classe à outra e, neste caso, ao ser instanciado um objetto da classe referenciada apenas um objeto é criado. Neste caso tratamos a associação por herança por dois elementos, uma superclasse e uma subclasse, ou seja esse tipo de associação visa especializar um comportamento a partir de uma generalização.</p>
    <p>Por exemplo:</p>
    <p>Temos uma aplicação onde, a classe principal, chamada Player, contém os métodos Play, Pause e Stop, e temos a classe Recorder, que além destes três métodos, possui um método chamado Record. Neste caso, para não termos que implementar novamente os três métodos que são iguais, podemos apenas criar a classe Recorder herdando a classe Player, desta maneira ela se torna uma especialização da classe principal, ou uma subclasse.</p>
    <p>
        <h4>Atrubuto Protected</h4>
            <p>Para encapsularmos de modo eficaz algum atributo ou método de modo que apenas as Subclasses tenham acesso precisamos utilizar o o atibuto protected ao invés dp private. No caso o protected permite o acesso aos atributos apenas para as classes herdeiras, desse modo, preservando que outros elementos do programa tenham acesso.</p>
    </p>
    <h2>Upcasting e Downcasting</h2>
        <p>
            <h3>Upcasting</h3>
                <p>Trata-se, de modo resumido, do casting da subclasse para a classe, comumente usado para criação de polimorfismos na classe principal.</p>
                <p>
                    Ou seja, se instaciarmos um objeto da classe pai, podemos atribuir o seu valor como um objeto da classe filho, nesse caso fazendo um upcasting, ou seja, elevando o grau de especificação desse objeto visto que todos os objetos da classe filho são pertencentes à classe pai por herança. O contrário, entretanto, não é possível pois os objetos da classe filho podem possuir especificações não compreendidas pela classe pai.
                </p>
            <h3>Downcasting</h3>
                <p>Como o nome sugere, é o processo inverso, do casting da superclasse, para a subclasse, pode ser identificado pelas palavras as/is. É comomente usado em métodos que recebem parâmetros genéricos.</p>
                <p>
                    O downcasting, em oposição ao upcasting, necessita que validemos se os tipos de objetos são compatíveis, ou seja, se podem, ser convertidos para os tipos desejados, isso de forma explicita pois, o .Net não consegue validar esse relacionamento de forma implicita. Por exemplo: instaciamos um objeto da classe pai como um novo objeto da classe filho A (isso é possível), em seguida atribuimos este este objeto A para um novo objeto da Classe filho, neste caso devemos dizer que o objeto que está sendo atribuído pertence à essa classe, isso usando tanto a sintaxe padrão (informando o tipo entre parenteses 'colado' antes da variável) ou a palavra 'as', que se destina à dizer que algo é (ou pertence) à classe mencionada.
                    <br/><br>
                    Outro porém é que precisamos sempre nos certificar que os objetos para o downcasting são compativeis, para isso podemos usar a instrução 'is' que retorna um boolean a partir da checagem se a classe do objeto à sua esquerda é igual à classe passada como parâmetro à direita, ex: if(pessoa is Human){}
                </p>
        </p>
        <p>Dentro de operações com Up e Downcasting temos a possibilidade, após instaciada um objeto a partir de um classe, alterarmos essa classe em relação ao seu relacionamento com as heranças.</p>
<h2>Sobreposição [virtual, base, override]</h2>
    <p>Tratamos por sobreposição a possibilidade de adequarmos comportamentos de métodos e/ou atributos em função da herança. Nesse caso podemos definir comportamentos alternativos para os métodos já implementados na classe pai adequando-os de acordo com as classes filho, mas mantendo seus nomes.
        <h4>Virtual</h4>
            <p>Para podermos utilizar a sobreposição de um método em uma classe herdeira, primeiramente precisamos incluir a instrução virtual no métodos que queremos alterar o comportamento. A instrução virtual diz que, para as classes herdeiras, este método permite ser sobreposto (ou sobrecarregado).</p>
        <h4>Override</h4>
            <p>O Override é uma instrução incluída no método que permite inferir um comportamento distinto para este método quando o objeto pertencer à classe na qual ele está escrito, ou seja, adequando o comportamento do método em função da classe do objeto. Desta maneira podemos evitar o uso de muitos métodos distintos quando, a depender da classe, um método possui um comportamento diferente.</p>
        <h4>Base</h4>
            <p>A palavra base serve para inferirmos o valor a partir da classe pai, ou seja, reutilizarmos o que há na classe pai da forma como é, seja um método ou a configuração de algum método ou construtor. Quando utilizado fora das chaves (escopo) deve ser precedido por ':' (dois-pontos), quando usado dentro ele faz as vezes do nome de um objeto, sendo usada a palavra base precedendo o método aplicado.</p>
    </p>
<h2>Classes e Métodos Selados</h2>
    <p>Para selarmos uma classe ou método incluímos a palavra sealed. O comportamento difere um pouco entre as classes e métodos:
        <h4>Classes</h4>
            <p>Quando selamos uma classe dizemos que esta não poderá ser herdada por outras subclasses, isso é muito usado para protegermos alguma regra de negócio para uso indevido ou mesmo para preservarmos alguns comportamentos encapsulados apenas dentro desta classe.</p>
        <h4>Métodos</h4>
            <p>
            Quando selamos um método isso implica que este não poderá ser sobreescrito mais de uma vez, ou seja, limitaremos a sobrecarga deste método à apenas uma herança. Isso é importante tando para controlarmos a sobrecarga desnecessária de métodos, o que pode gerar problemas diversos como para aumentar a performance pois, quando há um método selado o processamento se encerra antes de buscar por sobrecargas
            </p>
    </p>
<h2>Polimorfismo</h2>
    <p>
    Consiste de um paradigma onde podemos mudar os comportamentos e características de objetos em função de suas heranças e sobrecargas. Em resumos, o comportamento de cada objeto, mesmo pertencendo à mesma classe principal, muda em função de cada especificação.<br/>
    <b>Importante: a associação do tipo específico de um objeto é feita em tempo de execução, ou seja, durante o casting. O compilador não sabe, de modo prévio, quano o tipo especifico da chamada antes do castging ser realizado.</b>
    </p>
<h2>Classes Abstratas</h2>
    <p>Consistem de classes onde não é possivel instanciar objetos nela, apenas em suas classes herdadas. Isso posto, uma classe abstrata não pode ser acessada por nenhum outro local nem ser instanciada diretamente, apenas suas classes filhas e sobrecargas podem ser utilizadas. É muito útil quando temos que criar uma camada generica a partir da qual nossa entidades derivarão, desse modo protegendo e evitando erros. Para definirmos uma classe como abstrata basta adicionarmos a palavra abstract antes da declaração da classe (abstract public class <i>nome_da_classe</i>)</p>
    <h3>Métodos Abstratos</h3>
        <p>
            Podemos, também, criar métodos abstratos, estes precisam, obrigatóriamente, estar inclusos em uma classe abstrata. Por mais que sigam a mesma lógica, os métodos abstratos possuem algumas particularidades, por exemplo, eles não precisam levar virtual para poderem ser sobreencritos e precisam ser, obrigatóriamente, sobreescrito em todas as classes herdeiras.
        </p>
<h2>Exception</h2>
    <p>Exceção é o nome dado á uma condição de erro ou comportamento não esperado pelo programa em execução. No .Net todas as exceptions são objetos herdados do System.Exception e possuem como comportamento a propagação na pilha de chamadas aguardando que sejam capturadas ou que o programa seja encerrado. Podemos, assim como em outras tecnologias, criar nossas próprias exceções, porém além disso, podemos interceptá-las de modo que geremos comportamentos alternativos de modo à contornar erros e evitar quebras ou encerramentos indevidos do programa.</p>
    <p>A implementação de exceções também permite o tratamento de erros a partir do modelo de classes, tornando o código mais organizado e controlado, promovendo uma maior flexibilidade em relação ao tratamento de erros, usando boas práticas. Além disso também podemos hierquizar o controle de exceções e manipular os dados retornados pela exceção, permitindo maior aproveitamento da estrutura e maior assertividade no tratamento de erros.</p>
        <h3>Estrutura try-catch</h3>
            <p>A estrutura try-catch permite executarmos um trecho de código e, em seguida, setarmos um ou mais blocos de execução a partir da exception gerada pelo try. Desse modo podemos, além de evitarmos que os erros que eventualmente quebrariam o programa sejam tratados de modo específico, ou mesmo de modo generalista, apenas aplicando um bypass se aplicável. Outra facilidade que essa estrutura promove é podermos programar comportamentos distintos em virtude das exceptions que sejam retornadas, dessa forma podemos flexibilizar muito nosso código para que erros sejam contornados de acordo com suas causas.</p>
        <h3>Bloco finally</h3>
            <p>o bloco finally é aplicado para que, havendo ou não um lançamento de exception ele seja executado. Isso devido à algumas implementações em que há a necessidade de se efetuar uma ação posterior à execução do bloco try e/ou catch, desse modo garantindo que seja executada a instrução.</p>
        <h3>Criando exceptions personalizadas</h3>
            <p>Para criarmos uma ou mais exceptions novas precisamos criar uma nova classe, ou classes para cada grupo de exceções, e extender a classe para ApplicationException, neste caso iremos herdar todos os métodos e demais atributos necessários para criar uma exceção. A partir de então podemos instanciar o lançamento da exceção a partir da palavra trow, que faz as vezes do return. 
            <br/>
            Ao criarmos uma nova exception podemos, entre outras coisas, incrementar a mensagem, o código, os dados, e os demais atributos padrão que uma exception pode receber.
            </p>
<h2>Trabalhando com Arquivos</h2>
    <h3>File, FileInfo</h3>
        <p>Para trabalharmos com arquivos no C# precisamos utilizar a biblioteca System.IO, esta contém as classes e métodos que permitem abrirmos e tratarmos arquivos no formato de objetos FileStream. Neste caso temos os métodos comuns create, copy, delete, move, open, etc..</p>
        <h4>File</h4>
            <p>
                A classe file é uma classe que possui apenas mebros estáticos, ou seja, não requer a instanciação para que sejam acessados os métodos. Outro ponto é que, por não haver a instanciação, o sistema irá realizar uma verificação de segurança a cada operação realizada agregando uma perda de performance em virtude dessas verificações.
            </p>
        <h4>FileInfo</h4>
            <p>Já a classe FileInfo requer a instanciação do arquivo como um objeto da classe, nesse caso nao requerendo uma nova verificação de segurança a cada operação, mas agregando maior complexidade na implementação.</p>
    <h3>IOExceptions</h3>
        <p>Assim como outras bibliotecas, a biblioteca IO possui suas próprias exceptions.</p>
<h2>Abrindo e Lendo Arquivos</h2>
    <p>Podemos abrir e ler arquivos usando as classes File e FileInfo apenas passando o caminho completo, ou relativo, como argumento. No caso do FileInfo o instanciamos como um novo objeto do tipo FileInfo passando no construtor uma string com o caminho para o arquivo.<br/><br/><b>Dica: para evitarmos ter que aplicar escapes nos caminhos para os diret´roios podemos, ao invés disso, inserir um @ antes de começarmos a string, isso diz ao C# que o conteúdo da string trata-se de um endereço ao invés de uma string normal (iso quando estamos no windows, no linux a sintaxe dos diretórios é com barra comum ao invés de contra-barra).</b></p>
<h2>FileStream e StreamReader</h2>
    <p>Os objetos FileStream e StreamReader trabalham em conjunto, muitas vezes, para trabalharmos com arquivos, sendo estes, respectivamente, uma instânciação em modo binário do arquivo que estamos abrindo enquanto o outro uma camada de interpretação deste binário na forma de caracteres, desse modo podemos trafegar dados entre o arquivo e o código de modo sequencial (stream). O FileStream compreende basicamente as operações de read e write-bytes, enquanto que o StreamReader utiliza read-chars para sua leitura. Ambos os tipos de objeto podem ser instaciados de modos diversos, inclusive a partir de suas próprias classes.<br/><br/><b>Atenção: os objetos FileStream e StreamReader não são gerenciados pelo CLS do .Net, ou seja, são criados e manipulados diretamente pelo sistema operacional, nesse caso precisamos sempre fechá-los após o seu uso, podemos, portanto usar os métodos .Close() para essa finalidade.</b></p>
    <p>Um outro detalhe é que, para usarmos estes dois elementos precisamos instanciá-los previamente, ou utilizar algum método que o faça, sempre nos atentando que o StreamReader apenas lê objetos do tipo FileStream. Dessa forma podemos, ao invés de instaciar um FileStream e, em seguida, um objeto StreamReader, apenas criar um novo StreamReader vazio e atribuir o valor dele a partir de um objeto File ou FileInfo, usando algum método (.OpenText, por exemplo) que crie o FileStream de forma implícita.</p>
    <h3>Comportamento</h3>
        <p>Ao abrirmos um objeto de texto, por exemplo, este é instanciado como um vetor de strings e para podermos imprimir ou tratar todo o conteúdo precisamos percorrer este arquivo usando while ou foreach para isso.Dentro do StreamReader temos um métod chamado .EndOfStream que retorna um bool de acordo com o final do arquivo, podemos usar este como parâmetro para pararmos a execução de um loop caso optemos pelo while como método para percorrer os dados.</p>
<h2>Bloco <i>using</i></h2>
    <p>
        Podemos, também, instanciar nosso arquivo dentro de um bloco using, ou seja, encapsularmos o uso do arquivo dentro de um bloco para isolá-lo do restante do programa. Esse método é útil quando prevemos um uso momentâneo do dado em vez de usar o arquivo continuamente. Além disso, o using permite o uso de objetos Stream sem a necessidade de fecharmos eles manualmente, ou seja, este método irá fechar o objeto automaticamente quando encerrar sua execução.
        <br />
        Para usarmos um bloco using primeiro abrimos o bloco com using ('StreamObjectType' varName = new 'StreamObject'){}, essa sintaxe permite, inclusive, cascatearmos varios blocos using para encapsularmos e manejarmos os arquivos dentro do mesmo contexto e escopo.
    </p>
<h2>StreamWriter</h2>
    <p>Assim como ocorre com o StrearReader, o StreamWriter é uma classe que permite escrevermos sobre objetos Stream, dessa forma podemos enviar caracteres diretamente para o arquivo binário aberto e, consequentemente, escrever os nossos dados de modo direto. Sua aplicação segue a mesma lógica do StreamReader, ou seja, precisamos instanciar um StreamObject para atribuí-lo, então, ao StreamWriter.</p>
<h2>Directory & DirectoryInfo</h2>
    <p>Assim como podemos abrir arquivos, também podemos acessar pastas (diretórios) através do código, para isso usamos as classes Directory e DirectoryInfo. Essas classes tem funcionamento semelhante ao File e FileInfo, onde uma permite o acesso apenas aos módulos estáticos, não reqeurendo que instaciemos um objeto do tipo diretório, mas que, por conta disso, são mais lentas em relação ao DirectoryInfo que instancia um objeto.</p>
    <p>A utilização se dá passando o caminho do diretório através de uma string (ou usando o método com o @) e, a partir dele, podemos acessar, ler ou criar novos diretórios com o nosso programa. Isso é essencial em casos onde estamos desenvolvendo uma aplicação local, ou seja, instalada na máquina do usuário, ou quando temos um serviço web que, em determinadas situações, precisa criar novas pastas dentro do servidor para armazenar alguma informação.</p>
    <h3>Criando Pastas</h3>
        <p>Assim como nas classes File, aqui também podemos criar e excluir pastas em algum diretório, para isso temos os métodos Create e Delete, que irão criar ou excluir uma pstas nomeada <br/><b>Importante: Caso a pasta não exista o método Delete irá retornar uma exception, já o CReate, caso já exista uma pasta com o mesmo nome, ele irá sobreescrevê-la.</b></p>
    <h3>EnumerateFiles</h3>
        <p>Um método que também faz parte da classe directory é o EnumerateFiles, este método irá listar todos os arquivos contidos em uma pasta a partir de um parâmetro pattern.</p>
    <h3>searchPattern</h3>
        <p>O parâmetro searchPattern é muito comum na leitura de diretórios pois ele se destina a reconhecer quais arquivos e folders serão considerados na enumeração, ou seja, por ele podemos passar uma string que será usada para validar se um arquivo ou folder será considerado ou não. Por padrão ele busca apenas os diretórios caso o pattern seja uma string vazia, mas a depender do valor incluso podemos exibir todo o conteúdo (".", "*.*") ou estabelecer quais arquivos (por nome ou extensão) serão considerados na nossa leitura.</p>
<h2>Path</h2>
    <p>Consiste em uma classe que traduz e interpreta strings como caminhos de diretório. A classe path possui apenas membros estáticos e pode ser usada tanto para recuperar informações do computador quanto para criar caminhos específicos para o programa.</p>
<h2>Interfaces</h2>
    <p>
        Interface é um tipo que define um conjunto de operações que uma classe ou struct deve implementar.<br/>Por convenção, as interfaces são sempre declaradas começando por 'I', de modo à distinguí-las dos demais componentes do programa.
        <br/><br/>
        Em resumo, uma ionterface estabelece um contrato, ou seja, um conjunto de caracteríticas que as classes são obrigadas a seguir. O uso de interfaces permite criarmos sistemas com baixo acoplamento e flexíveis.
    </p>
    <p>
        Para usarmos uma interface precisamos, incialmente criá-la do mesmo modo que uma classe, porém usando a palavra interface ao invés de class. Dentro do corpo da interface criamos os métodos que serão aplicados a partir dela e, por fim, atribuimos ela dentro do programa ou classe que irá utilizá-la, sem, no entanto, atribuir um valor, apenas deixando-a como um atributo.
        <br />
        Ainda na construção da interface, precisamos associar as classes que realizaram essa interface, para isso estendemos essas classes do mesmo modo que em uma herança e nos certificamos que todos os métodos da classe correspondem aos métodos criados na interface.
    </p>
    <p>
        Em outras palavras, uma interface representa uma classe genérica, ou um atalho, para outra classe. Isso é importante pois, não precisamos alterar nada nos componentes que utilizam as classes da interface, apenas estes componentes. Caso haja a mudança de um deles apenas precisamos alterá-lo, de acordo com a interface, e atribuí-lo como extensão da interface em referência, ou seja, mesmo que mudemos a classe, o restante dos componentes não precisará ser refatorado.
    </p>
<h2>Inversão de Controle e Injeção de Dependência</h2>
    <p>
        Injeção de dependência diz do caso onde informamos durante a instanciação de um objeto, outro objeto do qual ele depende, ou seja, em tempo de execução, a ser instanciado o objeto pretendido, também será instanciado o objeto associado. Já a inversão de controle representa o cenário onde um componente ou serviço não é gerenciado por si só, e sim por outros locais no código (assim como no exemplo acima). Podemos gerar a inversão de controle de várias maneiras, mas essa é a principal.
    </p>
<h3>Herança vs Contrato</h3>
    <p>
        Os conceitos entre herança e contrato são bastante similares em relação às definições, ambas possuem os elementos principais genericos e elementos especializados vinculados assim como ambas possuem características polimórficas, ou seja, a partir do objeto genérico podemos aplicar comportamentos disntintos a depender da especialização necessária. Porém, há uma diferença crucial quanto à ambas pois, a partir de uma herança, atributos da classe genérica são propagados para as classes especializadas porém na interface (contrato) não há atributos a serem propagados, ela apenas aplica uma camada de generalização para flexibilizar a aplicação de um determinado recurso em virtude da sua especialização.
    </p>
<h2>IComparable</h2>
    <p>
        É uma interface padronizada para se realizar a comparação entre dois objetos. Ela se destina a casos onde precisamos realizar a ordenação de listas e vetores contendo objetos dado que, sem essa implementação, o CSharp não consegue estabelecer os parâmetros para a ordenação.
        <br />
        Sua implementação é simples, quando pretendemos aplicar a ordenação apenas precisamos estender a classe do objeto pretendido para IComparable e implementar a nossa lógica de comparação no método CompareTo.
    </p>
<h2>Generics</h2>
    <p>
        O uso de generics se destina a podermos reutilizar códigos mesmo com tipos de dados diferentes, ou seja, a mesma classe pode aceitar valores de tipos diferentes a partir de uma definição na chamada dessa classe.
        <br />
        Para declararmos uma classe genérica precisamos, após darmos o nome da classe, nomeramos um tipo genérico entre <> após o nome da classe: class Exemplo<"TipoGenérico">. Ao fazermos o casting dessa classe podemos, então, passar o tipo pretendido. Isso é bastante útil tanto para garantirmos segurança e evitarmos problemas na execução do código quanto para ganharmos performance nas operações.
        <br/>
        As generics foram criadas para evitar o uso de object como tipo genérico pois isso gera problemas diversos, desde incompatibilidade de tipos até problemas de performance nas operações.
    </p>
    <h3>Restrições para Generics</h3>
        <p>
            Para aplicarmos uma restrição à uma classe, método ou interface precisamos aplicar a palavra reservada where e estender a implementação do nosso tipo genérico para um tipo que contenha as restrições ou permissões do valor pretendido.
                <br /><br />
            Algumas restrições possíveis:
            <ul>
                <li>where Type : struct
                    <ul><li>Estendendo o tipo para structs</li></ul>
                </li>
                <li>where Type : class
                    <ul><li>Estendendo o tipo para uma classes apenas.</li></ul>
                </li>
                <li>where Type : unmanaged
                    <ul><li>Consiste em um grupo de tipos predefinidos que pode conter apenas valores não nulos e não ponteiros.</li></ul>
                </li>
                <li>where Type : new()
                    <ul><li>Apenas novos objetos contendo um construtor</li></ul>
                </li>
                <li>where Type : <'base type name'>
                    <ul><li>Um tipo básico específico.</li></ul>
                </li>
                <li>where Type : U
                    <ul><li>Outro tipo genérico.</li></ul>
                </li>
            </ul>
        </p>
<h2>GetHashCode & Equals</h2>
    <p>São operações nativas da classe object que, de modo genérico, se destinam a comparar dois objetos. Todos os tipos predefinidos já possuem essas operações.
        <h3>Equals</h3>
            <p>A operação equals possui uma performance inferior quando comparada à operação GetHashCode, porém seu retorno positivo sempre será 100% preciso, ou seja, estará livre de erros ou coicidências.</p>
        <h3>GetHashCode</h3>
            <p>Em contrapartida, a operação GetHashCode possui uma maior perfomance em relação ao Equals, porém pode conter erros nos resultados positivos decorrentes de coincidências ou falhas de comparação, neste caso carregando um certo grau de incerteza.</p>
            <p>No caso do GetHashCode ele irá inferir um valor para o objeto referenciado, este valor, no entanto, pode variar entre cada execução do projeto. O que gera alguma incerteza é o fato de, por ser feito a partir de um valor gerado aleatóriamente, poder haver um falso positivo devido o build ter inferido um valor duplicado. Neste caso é válido uma revalidação dos casos positivos para confirmar se há, de fato, a igualdade, neste caso usando o Equals.</p>
    </p>
<h2>HashSet<'t'> e SortedSet<'T'></h2>
    <p>
        Representam conjuntos de elementos, neste caso, cada conjunto não possui/permite repetições além de os seus elementos não possuirem uma posição, de modo que a inserção, acesso e remoção aos elementos se torna mais rápida, além disso, permitem também a interseção, unição e diferença entre estes conjuntos, facilitando processos de análise de conjuntos.
    </p>
    <h3>HashSet</h3>
        <p>Associa os valores à uma tabela hash, de modo que sua distribuição se torna aleatória e, em virtude disto, possui processos de busca, inserção e remoção de ordem 1. Dado isso a ordenação dos valores não é garantida.</p>
    <h3>SortedSet</h3>
        <p>Armazena os valores em uma estrutura de árvore primária. Dado isso, as operações de busca, inserção e remoção são de ordem log(n). Neste caso, como os valores são inseridos em estrutura de árvore podem permitir a ordenação durnate o armazenamento conforme a implementação do IComparer<'T'></p>
<h2>Testes de Igualdade em Estruturas Hash</h2>
    <p>Há duas formas principais de ser feita essa comparação, a primeira, caso haja a implementação do GetHashCode e do Equals ela fará a comparação entre o Hashcode do valor e validará, dentro da coleção, se este existe, então aplicará um Equals para confirmar. De modo geral ela irá comparar os hash codes de todos os valores para testar a igualdade.</p>
    <p>
        Já se não houver a implementação destes métodos na classe da coleção, ele irá comparar as referências dos objetos quando tipo for referência, ou comparará os valores quando o tipo for valor. 
    </p>
<h2>Dictionary & SortedDictionary</h2>
    <p>Compreende uma coleção de pares Chave/Valor (Key/Value) a qual não admite a repetição de objetos do tipo chave bem como são indexados a partir de suas chaves, não possuindo, assim, uma posição fixa. Além disso, coleções do tipo Dictionary são mais performaticas para acessar, inserir e remover valores visto não necessitarem percorrer a coleção para encontrar o valor requisitado.</p>
    <p>
        Uso comum: cookies, local storage e quaisquer modelos chave-valor.
        <br/>
        As coleções do tipo Dictionary existem em várias linguagens e tecnologias como JSON (uma estrutra integralmente constituída em dicionário), Python, JavaScript entre outras.
        <br />
        <b>As estruturas chave-valor também podem ser chamadas de mappings.</b>
    </p>
    <h3>Estrutura de um Dictionary</h3>
        <p>
            Um Dictionary possui a estrutura básica Tipo< tipoChave, tipoValor >, ou seja, Dictionary< Tkey, Tvalue >, em seguida nomeamos o objeto e iniciamos um novo objeto Chave-Valor. Além disso, o tipo referido à cada chave-valor é KeyValuePair< Tkey, Tvalue>. Essa estrutura é importante pois necessitamos passar o tipo de cada item caso queiramos evitar o uso de var nas chamadas que utilizam os objetos contidos em cada dicionário.
        </p>
        <p>
            Como pode ser visto, um dictinary é similar aos Set's, porém no caso dele há uma instanciação de objetos dentro da sua coleção, onde cada valor reprensenta um objeto KeyValuePair.
        </p>
        <p>
            <h4>Métodos dos Dictionary</h4>
                <ul>
                    <li>dictionary[key] - é uma maneira de invocar um atributo do dictionary a partir de sua chave. <b>Caso passemos uma key não existente atribuindo um valor esta será criada na coleção.</b></li>
                    <li>Add(key,value) - Permite adicionar uma chave-valor na coleção.</li>
                    <li>Clear() - esvazia a coleção.</li>
                    <li>Count - Retorna um int com a contagem de items da coleção.</li>
                    <li>ContainsKey(key) - retorna um boolean a partir da chave passada, se existir ou não.</li>
                    <li>ContainsValue(value) - retorna um boolean a partir do valor passado, se existir ou não.</li>
                    <li>Remove(key) - remove um elemento a partir da chave. Retorna exception se não há a chave passada.</li>
                </ul>
        </p>
<h2>Extension Methods</h2>
    <p>
        Os extension methods, ou extensões, são métodos auxiliares que podem ser cirados para uma determinada classe. Sua implementação é simples e sua principal característica é que são, sempre, métodos estáticos.
    </p>
    <p>
        Para criarmos uma extension basta escrevêla como um método estatico e, entre os parâmetros, inserir a 'this < tipo > nome do parâmetro' e, então, inserir os parâmetros que serã abordados. O parâmetro iniciado por <i>this</i> indica que o método sempre se aplicarà para o tipo apontado, sendo que somente será aplicado se o tipo do objeto for igual ao tipo this.
    </p>
    <p>
        Para facilitar a utilizadação podemos, inclusive, inserir o método dentro do namespace system (ou qualquer outro pretendido), mas é importante mantermos as boas práticas de criar as extensões dentro de um diretório dedicado, para isolá-los dos demais componentes do programa e facilitar a localização.
    </p>
<h2>Lambda, Delegates e LINQ</h2>
    <h3>Funções Lambda</h3>
        <p>
            As funçõs lambda, também conhecidas como funções anônimas, são funções que não são atribuídas por método e sim por uma variável, ou seja, não possuem a declaração padrão de função conhecida.
        </p>
        <p>
            Para declararmos uma função lambda, primeiramente criamos uma variável com o tipo que pretendemos sair da nossa função (exceto quando void) a atribuímos como valor uma função ou cálculo com a seguinte sintaxe: p (atributo) => (representa o começo da função) p1 * p2 (p1 e p2 aqui são os valores que serão multiplicados, ou seja, os parâmetros). Podemos também usar lambda com análises lógicas, de modo que sua saída será um boolean. Por fim, podemo também usar das funções anônimas como parâmetros de algum método.
        </p>
        <p>
            Há, no entanto, várias maneiras diferentes de declararmos funções lambda, onde podemos abrir e fechar chaves para indicar um return, executar algum outro método externo sobre o valor, etc...
        </p>
        <p>
            As funções lambda são, no entanto, muito importantes para utilizarmos com os métodos derivados do Linq, além de permitirem maior encapsulamento de ações onde podemos instanciar menos métodos de uso pontual para implementá-los como lambda diretamento nos métodos principais.
        </p>
    <h3>Comparison< T ></h3>
        <p></p>
    <h3>Programação Funcional e Cálculo Lambda</h3>
        <p>
            Dentro da programação funcional costumamos trabalhar com um conjunto de padrões nos quais alteramos alguns comportamentos quanto à estruturação das nossas funções. Dito isso alguns pontos se destacam:
            <ul>
                <li>Descrição das Funções - Na progrmação funcional as funções são criadas com o intuito de fazerem algo, ou seja, são recuperadas e criadas com o intuito de 'o quê fazer'. Já na programação Imperativas as funcções são meios para algo ser feito, ou seja, 'como fazer'. Isso implica em menos código criado e maior agilidade e assertividade na implementação.</li>
                <li>Transparência Referêncial - Diz dos elementos usados pelas funções não serem instanciados fora do escopo da função.</li>
                <li>Objetos Imutáveis - permitem a paralelização de execução além de sere thread-safe, ou seja, não alteráveis por processos simultâneos.</li>
                <li>Funções de Primeira Ordem - É uma característica que permite que as funções possam ser passadas como parâmetros de outros métodos.</li>
                <li>Inferência de Tipos - Diz da característica em que os tipos das variáveis não precisam ser passados na função, deixando a tipagem a cargo do compilador.</li>
            </ul>
        </p>
    <h3>Funções Lambda</h3>
        <p>
            Dentro do cenário de programação funcional, uma expressão lambda representa uma função anônima de primeira classe (ou Primeira Ordem).
        </p>
<h3>Delegates</h3>
    <p>
        Representa um tipo referência, com type safety, para um ou mais métodos.
    </p>
    <p>Em linhas gerais, um delegate é aplicado para garantir associar e garantir que os métodos relacionados à ele estão de acordo com os tipos de entrada e saída esperados.</p>
    <p>
        Para declararmos um delegate basta iniciar a palavra reservada delegate, em seguida o tipo esperado (no caso para o retorno) e, entre parantesis, os parâmetros que são esperados para os métodos. O que isso significa? Se passarmos apenas um parâmetro int no nosso delegate, apenas os métodos que tenham a mesma saída esperada e apenas um parâmetro, serão atribuídos.
    </p>
    <p>
        Assim, com o delegate, podemos atribuir uma função (método) para uma variável, aplicando de forma implicita os tipos relacionados no delegate. Além disso, o delegate é aplicado como um objeto, ou seja, ao ser atribuído como valor à uma variável, esta variável passa a se comportar como um objeto que executa a função.
    </p>
    <h4>Multicast Delegates</h4>
        <p>
            Com o delegate podemos também aplicar o multicast, ou seja, termos mais de um método atribuído ao mesmo objeto delegate sendo que todos os métodos atribuídos serão executados na ordem que foram adicionados no objeto. Para isso não faz sentido usá-lo com funções que retornam valor (a menos que seja preciso orquestrar uma série de cálculos sequenciais). Para adicionarmos um método ao objeto podemos usar o '+='.
        </p>
    <h3>Predicate</h3>
        <p>
            É um conjunto de métodos que recebe um objeto como parâmetro e retorna um boolean. Mas além disso, um predicate consiste de um método nativo que já implementa um delegate com retornos bool, e que pode receber tanto um outro método quanto uma função lambda, apenas precisamos nos certificar que nosso lambda retorna um bool como resultado.
        </p>
    <h3>Action</h3>
        <p>
            Segue a mesma linha do predicate, porém ela se destina à interações (geralmente com coleções) porém permite atribuirmos métodos que efetuem uma ação ou alteração nos valores / objetos aos quais foi aplicada. Esse delegate permite fazermos até 16 sobrecargas, de modo que cada sobrecarga representa a adição de um tipo ao seu conteúdo.
        </p>
    <h3>Func</h3>
        <p>
            É um delegate pertencente ao LINQ, o func age do mesmo módo que o Action, porém ele não se destina a alterar os valores e sim retornar um novo valor a partir do original. Uma aplicação comum de FUNC é com o .Select, de modo que, ao aplicarmos a função pretendida, retornamos uma nova lista a partir da transformação.
        </p>
<h2>LINQ</h2>
    <p>
        Consiste de um conjunto de tecnologias para consultas, baseada no C#. Basicamente o Linq reúne uma coleção de métodos e extensions para que possamos trabalhar com coleções de modo simplificado e direto.
    </p>
    <p>
        Além disso, o Linq permite instanciar as consultas como objetos de primeira classe e possui suporte do compilador, o que ajuda no desenvolvimento das mesmas. Por último, os métodos do Linq permitem que as chamadas sejam feitas diretamente para as coleções, o que permite maior flexibilidade e menor quantidade de código.
    </p>
    <p>
        <i>Além dos métodos normais, várias operações de consulta permitem que utilizemos também expressões lambda ou expressões com sintaxe similar às do SQL.</i>
    </p>