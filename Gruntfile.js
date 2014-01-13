var o = {};

o.OUTPUT_DIR = "bin/js/";
o.TEST_DIR = "bin/tests/";

o.DEMO_FILE = "demo.js";
o.RELEASE_FILE = "deagent.js";
o.TEST_FILE = "deagent.n";

o.DEMO_PATH = o.OUTPUT_DIR + o.DEMO_FILE;
o.RELEASE_PATH = o.OUTPUT_DIR + o.RELEASE_FILE;
o.TEST_PATH = o.TEST_DIR + o.TEST_FILE;

o.TEST_COMMAND = "neko " + o.TEST_PATH;
o.RUN_COMMAND = "node " + o.DEMO_PATH;

function register_dependencies(grunt) {
    'use strict';

    grunt.loadNpmTasks('grunt-haxe');
    grunt.loadNpmTasks('grunt-shell');
}

function clean(grunt){
    return function(){
        grunt.file.delete('bin');
    }
}

function make_dirs(grunt){
    return function(){               
        grunt.file.mkdir(o.OUTPUT_DIR);
        grunt.file.mkdir(o.TEST_DIR);
    };
}

function register_tasks(grunt){
    'use strict';

    grunt.registerTask('clean', 'Cleans all built files', clean(grunt));    
    grunt.registerTask('make_dirs', 'Make bin and test directories', make_dirs(grunt));
    
    grunt.registerTask('build', 'Build the project.', ['clean', 'make_dirs','haxe:js','haxe:test']);
    grunt.registerTask('unit_tests', 'Run the example', ['build','shell:unit_tests']);

    grunt.registerTask('default', 'build');
}

module.exports = function (grunt) {
    'use strict';    

    grunt.initConfig({        
        shell: {
            options: { stdout: true, stderr: true },            
            unit_tests:{
                command: o.TEST_COMMAND
            }
        },
        haxe: {
            js: {                
                hxml: 'targets/js.hxml'
            },
            test: {
                hxml: 'targets/test.hxml'
            }
        }
    });

    register_dependencies(grunt);
    register_tasks(grunt);
};