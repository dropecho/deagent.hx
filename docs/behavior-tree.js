'use strict';


TaskBank.register('debug', ctx => {
  ctx.increment('exec');
  console.log('Debug', ctx.get('exec'));
  return bt.NODE_STATUS.SUCCESS;
});

TaskBank.register('fail', ctx => {
  ctx.increment('exec');
  console.log('FAIL', ctx.get('exec'));
  return bt.NODE_STATUS.FAILURE;
});

var testNode1 = new bt.TaskNode('debug');
var testNode2 = new bt.TaskNode('fail');

var seqNode = new bt.SequenceNode([
  new bt.TaskNode('debug'),
  new bt.TaskNode('fail'),
  new bt.TaskNode('debug'),
]);
var rootNode = new bt.RepeaterNode(seqNode);
var exampleBT = new bt.BehaviorTree(rootNode);

var context = new Blackboard();
context.set('exec', 0);

exampleBT.init(context);
exampleBT.execute();
exampleBT.execute();
exampleBT.execute();
exampleBT.execute();

// var seqNode = new bt.SequenceNode([testNode1, testNode2]);
// setInterval(() => exampleBT.execute(), 500);
//
// var testNode1 = {
//   init: function(context) {
//     this.context = context;
//     this.context.set('bar', 1);
//   },
//   execute: function() {
//     console.log('node 1: ', this.context.get('bar'));
//     if(this.context.get('bar') < 5) {
//       this.context.set('bar', this.context.get('bar') + 1);
//       return bt.NODE_STATUS.RUNNING;
//     }
//     return bt.NODE_STATUS.SUCCESS;
//   }
// };
//
// var testNode2 = {
//   init: function(context) {
//     this.context = context;
//     context.set('bar', 1);
//   },
//   execute: function() {
//     console.log('node 2: ', this.context.get('bar'));
//
//     if(this.context.get('bar') > 2) {
//       this.context.set('bar', this.context.get('bar') -1);
//       return bt.NODE_STATUS.RUNNING;
//     }
//     return bt.NODE_STATUS.SUCCESS;
//   }
// };


