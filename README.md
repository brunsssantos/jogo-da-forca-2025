# Jogo da Forca

![](https://imgur.com/FoK7hcZ.gif)

## Introdução
Este é um jogo da forca desenvolvido em C# para ser executado no console. O jogo seleciona aleatoriamente uma palavra secreta de uma lista de frutas e permite que o jogador tente adivinhar as letras. O jogador tem um limite de 5 erros antes de perder a partida.

## Como Jogar
1. O jogo exibirá uma palavra secreta representada por underscores (`_ _ _ _`).
2. O jogador deve inserir uma letra por vez para tentar adivinhar a palavra.
3. Se a letra estiver na palavra, será revelada na posição correspondente.
4. Se a letra não estiver na palavra, o jogador acumula um erro.
5. O jogo termina quando:
   - O jogador adivinha todas as letras corretamente (vitória).
   - O jogador comete 5 erros e é "enforcado" (derrota).

## Estrutura do Código
- A lista de palavras está armazenada em um array de strings.
- O jogo utiliza a classe `Random` para selecionar uma palavra aleatoriamente.
- Um loop `do-while` controla a entrada do jogador e verifica se a letra digitada está na palavra.
- Um contador de erros determina se o jogador perde o jogo.
- A representação gráfica do boneco da forca é exibida no console de acordo com os erros acumulados.

## Tecnologias Utilizadas: 
[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio,)](https://skillicons.dev)

Divirta-se jogando!

