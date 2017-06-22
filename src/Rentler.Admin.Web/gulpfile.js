/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var del = require('del');

// Defining some handy paths
var paths = {
    npmInstall: "./node_modules/",
    npmClient: "./src/libs/",
    appDevelopment: ['./Scripts/**/*.html', './Scripts/**/*.css'],
    appClient: "./wwwroot/app/"
};

gulp.task('npmCopyToLibs', ['GulpClean'], function () {
    gulp.src(paths.npmInstall + '@angular/**/*.js').pipe(gulp.dest(paths.npmClient + '@angular'));
    gulp.src(paths.npmInstall + '@angular/**/*.css').pipe(gulp.dest(paths.npmClient + '@angular'));
    gulp.src(paths.npmInstall + '@angular/**/*.scss').pipe(gulp.dest(paths.npmClient + '@angular'));
    gulp.src(paths.npmInstall + '@angular/**/*.map').pipe(gulp.dest(paths.npmClient + '@angular'));
    //gulp.src(paths.npmInstall + 'core-js/**/*.js').pipe(gulp.dest(paths.npmClient + 'core-js'));
    //gulp.src(paths.npmInstall + 'zone.js/**/*.js').pipe(gulp.dest(paths.npmClient + 'zone.js'));
    //gulp.src(paths.npmInstall + 'rxjs/**/*.js').pipe(gulp.dest(paths.npmClient + 'rxjs'));
    //gulp.src(paths.npmInstall + 'hammerjs/**/*.js').pipe(gulp.dest(paths.npmClient + '@hammerjs'));
    //Eg. for the systemjs packages :
    // -- 1) gulp.src() :  in ./node_modules/systemjs/ from all directories and their subtrees (**) select all Javascript files (*.js).
    // -- 2) gulp.pipe() : send that file collection to something - in our case send the file collection to gulp.dest().
    // -- 3) gulp.dest() : take the incoming file collection and write it to ./wwwroot/libs/systemjs folder.

});

// While of no relevance in this QuickStart tutorial, a real Angular application will have many .html templates and related .css files
// -- these files are not automatically copied by the Typescript compiler and
// -- therefore needs to be separately copied to the wwwroot\app folder.
/*gulp.task('copyApp', function () {
    gulp.src(paths.appDevelopment).pipe(gulp.dest(paths.appClient));
});*/

gulp.task('GulpClean', function () {
    return del([paths.npmClient]);

    // 'clean' is a dependency task (of copyLibs), it is a good habit to return from dependency tasks
    // -- not because it is necessary as a signal to Gulp that the task have finished
    // -- but because that is the only way to transfer a stream to the next task.
});

gulp.task('RentlerDefaultPackage', ['npmCopyToLibs'], function () {
    // place code for your default task here
});