# BoomBeats

BoomBeats é uma plataforma de console para registrar e avaliar artistas e álbuns de hip-hop. Permite aos usuários gerenciar uma base de dados de artistas, álbuns e avaliações.

## Funcionalidades

- Registrar novos artistas
- Registrar álbuns para artistas existentes
- Avaliar artistas
- Avaliar álbuns
- Listar todos os artistas registrados
- Exibir detalhes de um artista específico

## Como usar

1. Execute o programa
2. Você verá um menu com as seguintes opções:
   1. Registrar uma banda/artista
   2. Registrar o álbum de uma banda/artista
   3. Avaliar uma banda/artista
   4. Avaliar um álbum
   5. Mostrar todas as bandas/artistas
   6. Exibir os detalhes de uma banda/artista
   -1. Sair do programa

3. Digite o número correspondente à ação desejada e pressione Enter
4. Siga as instruções na tela para cada operação

## Estrutura do projeto

O projeto utiliza um sistema de menus para navegação e interação do usuário. Cada opção do menu é representada por uma classe que implementa a interface `Menu`.

As principais classes do modelo de dados são:
- `Banda`: Representa um artista ou banda
- `Album`: Representa um álbum musical
- `Avaliacao`: Representa uma avaliação numérica

## Artistas pré-cadastrados

O sistema vem com alguns artistas de hip-hop brasileiros pré-cadastrados:
- Baco Exu do Blues
- BK
- Djonga
- aJuliaCosta
- KayBlack
- L7NNON
- Major RD

## Instalação

1. Clone o repositório:
   ```
   git clone https://github.com/seu-usuario/BoomBeats.git
   ```
2. Navegue até o diretório do projeto:
   ```
   cd BoomBeats
   ```
3. Compile e execute o projeto usando o .NET CLI:
   ```
   dotnet run
   ```

## Requisitos

- .NET 6.0 ou superior

## Contribuindo

Contribuições são bem-vindas! Por favor, siga estes passos:

1. Faça um fork do projeto
2. Crie sua branch de feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## Licença

Distribuído sob a licença MIT. Veja `LICENSE` para mais informações.

## Contato

Matheus Filipe de Deus - [instagram: @mxtheusfilipe] (https://www.linkedin.com/in/matheusfilipesilva/) - matheusfilipedesilva@gmail.com
