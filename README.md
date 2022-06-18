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
        <tr style="font-weight: bold; font-size: 20px; text-align: center">
            <td style="color: darkgrey; font-weight:bold;">C# Type</td>
            <td style="color: darkgrey; font-weight:bold;">.Net Framework Type</td>
            <td style="color: darkgrey; font-weight:bold;">Signed</td>
            <td style="color: darkgrey; font-weight:bold;">Bytes</td>
            <td style="color: darkgrey; font-weight:bold;">Possible Values</td>
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
<<<<<<< HEAD
</p>
=======
</p>
<h2>Próxima Aula</h2>
<p></p>
>>>>>>> 2da6083 (Commit)
