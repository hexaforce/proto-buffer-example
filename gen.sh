#!/bin/bash

current_dir=$(cd $(dirname $0); pwd)

gen_dir=gen
proto_dir=proto

language=(
 "cpp"
 "csharp"
 "go"
 "grpc-web"
 "java"
 "js"
 "kotlin"
 "php"
 "python"
 "ruby"
)

rm -rf $gen_dir
mkdir $gen_dir

cd $current_dir/$gen_dir

for lang in ${language[@]}; do
mkdir $lang
done

cd $current_dir

proto_files=$(find $proto_dir -type f -name "*.proto" -exec basename {} \;)

for file in $proto_files; do
protoc --proto_path=$proto_dir \
 --cpp_out=$gen_dir/cpp \
 --csharp_out=$gen_dir/csharp \
 --go_out=$gen_dir/go \
 --grpc-web_out=import_style=typescript,mode=grpcwebtext:$gen_dir/grpc-web \
 --java_out=$gen_dir/java \
 --js_out=import_style=typescript:$gen_dir/js \
 --kotlin_out=$gen_dir/kotlin \
 --php_out=$gen_dir/php \
 --python_out=$gen_dir/python \
 --ruby_out=$gen_dir/ruby \
$file
done
