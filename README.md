# Aula01Variaveis

 ##teste de edição

 # Aula01Variaveis

## 📚 Manual básico de Markdown (`.md`)

**Nome:** **Rafael Camargo Ribeiro**

**Matéria:** DSII

**Data:** __12_ / __08__ / ___2026___

---

## 1. O que é um arquivo `.md`?

Um arquivo com extensão `.md` é um arquivo de **Markdown**. Ele permite escrever textos utilizando formatações simples por meio de símbolos.

O Markdown é muito utilizado em projetos de programação, principalmente em arquivos `README.md`, para explicar o funcionamento de um projeto.

---

## 2. Títulos

Para criar títulos, usamos o símbolo `#`.

Quanto mais `#`, menor será o nível do título.

```markdown
# Título 1
## Título 2
### Título 3
#### Título 4
```

Exemplo:

# Título 1

## Título 2

### Título 3

---

## 3. Texto em negrito

Para deixar uma palavra ou frase em **negrito**, coloque dois asteriscos antes e depois:

```markdown
**Texto em negrito**
```

Resultado:

**Texto em negrito**

---

## 4. Texto em itálico

Para colocar uma palavra ou frase em *itálico*, utilize um asterisco de cada lado:

```markdown
*Texto em itálico*
```

Resultado:

*Texto em itálico*

---

## 5. Negrito e itálico juntos

Também podemos utilizar os dois formatos:

```markdown
***Texto em negrito e itálico***
```

Resultado:

***Texto em negrito e itálico***

---

## 6. Listas

### Lista não numerada

Use `-`, `*` ou `+` no início de cada linha.

```markdown
- Variáveis
- Constantes
- Tipos de dados
- Operadores
```

Resultado:

* Variáveis
* Constantes
* Tipos de dados
* Operadores

### Lista numerada

Use números seguidos de ponto:

```markdown
1. Criar o projeto
2. Criar as variáveis
3. Executar o programa
4. Testar o resultado
```

Resultado:

1. Criar o projeto
2. Criar as variáveis
3. Executar o programa
4. Testar o resultado

---

## 7. Links

Para adicionar um link, utilizamos:

```markdown
[Nome do site](https://www.exemplo.com)
```

Exemplo:

[Google](https://www.google.com)

---

## 8. Imagens

Para adicionar uma imagem:

```markdown
![Descrição da imagem](caminho-da-imagem.png)
```

Exemplo:

```markdown
![Logo do projeto](imagens/logo.png)
```

A descrição entre `[]` é chamada de **texto alternativo**.

---

## 9. Código

Para destacar uma pequena parte de código, utilize uma crase:

```markdown
`int idade = 18;`
```

Resultado:

`int idade = 18;`

Para blocos maiores de código, utilize três crases:

````markdown
```java
public class Main {
    public static void main(String[] args) {
        int idade = 18;
        System.out.println(idade);
    }
}
```
````

---

## 10. Tabelas

Podemos criar tabelas utilizando `|` para separar as colunas.

```markdown
| Variável | Tipo | Exemplo |
|---|---|---|
| idade | int | 18 |
| nome | String | João |
| altura | double | 1.75 |
```

Resultado:

| Variável | Tipo   | Exemplo |
| -------- | ------ | ------- |
| idade    | int    | 18      |
| nome     | String | João    |
| altura   | double | 1.75    |

---

## 11. Citações

Para criar uma citação, utilize `>`:

```markdown
> Aprender programação é praticar todos os dias.
```

Resultado:

> Aprender programação é praticar todos os dias.

---

## 12. Linha horizontal

Para criar uma linha horizontal, podemos utilizar três hífens:

```markdown
---
```

Resultado:

---

## 13. Emojis

Também é possível utilizar emojis para deixar o README mais visual.

```markdown
📚 Estudos
💻 Programação
🚀 Projeto
✅ Concluído
⚠️ Atenção
```

Exemplo:

📚 Estudos
💻 Programação
🚀 Projeto
✅ Concluído

---

## 14. Como colocar um GIF

Um GIF pode ser inserido utilizando a mesma sintaxe usada para imagens:

```markdown
![Exemplo de GIF](imagens/exemplo.gif)
```

Exemplo:

![Exemplo de GIF](https://media.giphy.com/media/26tn33aiTi1jkl6H6/giphy.gif)

> 💡 Em um projeto, é recomendado salvar o GIF dentro de uma pasta, como `imagens/`, e utilizar o caminho do arquivo.

Exemplo de organização:

```text
Aula01Variaveis/
│
├── README.md
├── src/
└── imagens/
    └── exemplo.gif
```

---

## 15. Desenhos com Markdown

O Markdown não possui uma ferramenta própria para desenhar imagens complexas, mas podemos utilizar **ASCII Art**, criando desenhos com caracteres.

Exemplo:

```text
       ___________
      /           \
     /   AULA 01   \
    |   VARIÁVEIS   |
     \             /
      \___________/
           |
        ___|___
       |       |
       |  💻   |
       |_______|
```

Também podemos criar diagramas simples:

```text
+------------------+
|     PROGRAMA     |
+--------+---------+
         |
         v
+------------------+
|    VARIÁVEIS     |
+--------+---------+
         |
         v
+------------------+
|     RESULTADO    |
+------------------+
```

---

## 16. Exemplo de uma variável

Em programação, uma variável é utilizada para armazenar um valor.

Exemplo em Java:

```java
int idade = 18;
String nome = "João";
double altura = 1.75;
```

Nesse exemplo:

* `idade` armazena um número inteiro;
* `nome` armazena um texto;
* `altura` armazena um número decimal.

---

## 17. Exemplo completo de Markdown

Um pequeno arquivo Markdown poderia ser escrito assim:

````markdown
# Meu Projeto

## Sobre

Este é um projeto desenvolvido durante a aula de programação.

### Variáveis

- `int`
- `double`
- `String`
- `boolean`

### Exemplo

```java
int idade = 18;
System.out.println(idade);
````

### Imagem

![Imagem do projeto](imagens/projeto.png)

### GIF

![GIF do projeto](imagens/exemplo.gif)

````

---

## 18. Resumo dos principais comandos

| Markdown | Função |
|---|---|
| `# Título` | Título |
| `**texto**` | Negrito |
| `*texto*` | Itálico |
| `- item` | Lista |
| `1. item` | Lista numerada |
| `[texto](link)` | Link |
| `![texto](imagem)` | Imagem |
| `` `código` `` | Código em linha |
| `> texto` | Citação |
| `---` | Linha horizontal |
| ` ``` ` | Bloco de código |

---

## 19. Conclusão

O Markdown é uma forma simples de criar documentos organizados e visualmente agradáveis. Ele é muito útil para documentar projetos, criar arquivos `README.md`, explicar códigos e apresentar informações de maneira clara.

**Projeto:** Aula01Variaveis

**Nome:** __________________________________________

**Matéria:** ________________________________________

**Data:** ____ / ____ / ______
````

