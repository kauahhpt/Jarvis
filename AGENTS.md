# Jarvis

## Objetivo do projeto

O Jarvis é um projeto experimental de agente de IA desenvolvido para aprender e explorar como agentes podem interpretar instruções em linguagem natural, escolher ferramentas e executar ações em um computador ou dispositivo móvel.

A visão de longo prazo é criar um agente pessoal capaz de controlar um smartphone através de linguagem natural, de forma semelhante ao conceito fictício do JARVIS do Tony Stark.

## Objetivo atual

Neste momento estamos construindo apenas um agente experimental em C#/.NET para aprender os fundamentos de agentes.

A primeira versão terá ferramentas simples para manipulação de arquivos e pastas.

Exemplo de objetivo:

"Crie uma pasta chamada Teste e dentro dela crie um arquivo hello.txt com o texto Olá mundo."

O agente deverá interpretar o objetivo, escolher as ferramentas apropriadas e executá-las.

## Tecnologias atuais

- C#
- .NET 10
- Visual Studio
- Git
- GitHub

## Futuro

Depois de compreender e validar o funcionamento de agentes no computador, o projeto poderá evoluir para Android.

A visão futura inclui:

- reconhecimento de voz;
- interpretação de linguagem natural;
- planejamento de tarefas;
- tool calling;
- execução de ações;
- observação do estado da interface;
- memória e contexto;
- Android AccessibilityService;
- controle de aplicativos;
- execução de tarefas compostas.

## Regras de desenvolvimento

- O projeto também é um projeto de aprendizagem.
- O desenvolvedor deve entender o funcionamento do código antes de adotá-lo.
- Evitar abstrações desnecessariamente complexas.
- Explicar decisões arquiteturais importantes.
- Priorizar código simples e legível.
- Não implementar funcionalidades futuras antes de validar a funcionalidade atual.
- Não substituir lógica por regras específicas para frases individuais quando o objetivo for construir um agente generalizável.
- Ferramentas devem ter responsabilidades bem definidas.
- O agente deve decidir quais ferramentas utilizar.
- Não colocar lógica de negócio diretamente nas ferramentas.
- Alterações devem ser pequenas e facilmente testáveis.

## Papel do Codex

O Codex atua como assistente de programação.

Ele pode:

- analisar o projeto;
- sugerir implementações;
- criar ou modificar arquivos;
- corrigir erros;
- explicar problemas;
- refatorar código quando necessário.

Antes de fazer alterações significativas, o Codex deve considerar o conteúdo deste arquivo e preservar as decisões arquiteturais já estabelecidas.