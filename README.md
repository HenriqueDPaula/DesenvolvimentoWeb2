# DesenvolvimentoWeb2
# ASP.NET CORE

**Dependency Injection** ou DI é um padrão de projeto que tem como objetivo a diminuição de acoplamentos com a uitlização<br> de interfaces, ou seja, diminuir as junções entre as partes do código, evitando a alta complexidade do sistema com o decorrer do tempo.<br>
Tem como vantagens:<br>
-A reutilização e manutenção do código;<br>
-O código é testável e extensivo<br>
-Codificação simples, aplicavel em qualquer situação onde os comportamentos são diferentes.<br>

Como por exemplo uma interface 'IDependencia' que invoque o método AddSingleton, que faz com que uma única instância<br> da classe 'Dependencia' seja utilizada na resolução das dependências baseadas nesta interface.<br>

Há 3 formas de injeção de dependencia: Constructor injection, setter injection e interface injection.<br>

**Constructor**:<br>
Um modelo onde a interface ICalculate foi implementada na classe Calculate.<br>
public readonly ICalculate Calculate;<br>
public HomeController(ICalculate calculate)<br>
{<br>
    Calculate = calculate;<br>
}<br>
<br>
**Setter**<br>
public class Global<br>
{<br>
    public ICalculate Calculate { get; set; }<br>
}<br>
<br>
**Interface**<br>
public class Global<br>
{<br>
    public void setCalculate(ICalculate calculate)<br>
    {<br>
        Calculate = calculate; <br>       
    }<br>        
    public ICalculate Calculate { get; private set; }<br>
}<br>

Todas as instancias resolvidas via injeção de dependencia serão associadas a propriedades do objeto **ViewBag**.<br>
Exemplo:<br>
Objeto A: @ViewBag.ObjetoA.(alguma Guid)<br>



