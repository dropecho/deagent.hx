var graphEl = d3.select("#d3").graphviz();
var blackboardEl = document.querySelector("#blackboard");

const context = new Blackboard();
context.set("fact", 0);

const my_fsm = new fsm.FSM();

const s1 = {
  getName: () => "s1",
  onEnter() {},
  onExit() {},
  tick: () => console.log("s1 tick", context.increment("fact")),
};

const s2 = {
  getName: () => "s2",
  onEnter() {},
  onExit() {},
  tick: () => console.log("s2 tick", context.decrement("fact")),
};

const s3 = {
  getName: () => "s3",
  onEnter() {},
  onExit() {},
  tick: () =>
    console.log("s3 tick", context.set("fact", Math.floor(Math.random() * 10))),
};

my_fsm.addTransition(s1, s2, () => context.get("fact") >= 2);
my_fsm.addTransition(s2, s3, () => context.get("fact") <= 0);
my_fsm.addTransition(s3, s2, () => context.get("fact") <= 4);
my_fsm.addTransition(s3, s1, () => context.get("fact") >= 5);

my_fsm.changeToState(s1);

setInterval(() => {
  my_fsm.tick();
  var dot = my_fsm.toDot();
  console.log(dot);
  graphEl.renderDot(dot);

  var rows = Object.entries(context.facts)
    .map((entry) => {
      var key = entry[0];
      var value = entry[1];
      return `<tr><td>${key}</td><td>${value}</td></tr>`;
    })
    .join("\n");

  blackboardEl.innerHTML = `
    <header>World State</header>
    <table>
    <tr><th>fact</th><th>value</th></tr>
    ${rows}
    </table>
  `;
}, 1000);
