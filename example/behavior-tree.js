'use strict';

var testNode1 = {
    execute: function(){
        console.log('node 1');
        return ['SUCCESS', 1];
    }
};

var testNode2 = {
    execute: function(){
        console.log('node 2');
        return ['SUCCESS', 1];
    }
};



var seqNode = new de.bt.SequenceNode([testNode1, testNode2]);

var rootNode = new de.bt.RepeaterNode(seqNode);
var exampleBT = new de.bt.BehaviorTree(rootNode);

