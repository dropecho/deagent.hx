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

var seqNode = new de.bt.SequenceNode([testNode1, testNode2]);

var rootNode = new de.bt.RepeaterNode(seqNode);
var exampleBT = new de.bt.BehaviorTree(rootNode);
