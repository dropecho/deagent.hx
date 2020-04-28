'use strict';

var testNode1 = {
  execute: function() {
    console.log('node 1');
    return 0;
  }
};

var testNode2 = {
  execute: function() {
    console.log('node 2');
    return 0;
  }
};

var seqNode = new bt.SequenceNode([testNode1, testNode2]);

var rootNode = new bt.RepeaterNode(seqNode);
var exampleBT = new bt.BehaviorTree(rootNode);
