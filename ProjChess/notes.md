<h1>Arquitetura Básica</h1>
    <p>
        Pensando na aplicação de boas práticas, o projeto irá se segmentado em camadas onde cada uma será responsável por uma macro-área do programa.
    </p>
    <h2>Camadas</h2>
        <h3>Aplicação</h3>
            <p>A camada de aplicação será responsável pela aplicação propriamente dita, onde serão lidos e instanciados as lógicas dasa outras duas camadas e, então, executada a aplicação como pretendido.</p>
        <h3>Jogo Xadrez</h3>
            <p>Aqui será implementada a lógica geral por trás do jogo, como as regras de funcionamento, mecânicas e movimentações em geral. Aqui também serão inclusos os comportamentos como roque, xeque e xeque-mate, retomada de peças, entre outros.</p>
        <h3>Tabuleiro</h3>
            <p>Será responsável por carregar as definições do tabuleiro, peças, comportamentos básicos relacionados ao tabuleiro entre outras features menores.</p>