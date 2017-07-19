﻿using AutoRest.Php.PhpBuilder.Expressions;
using AutoRest.Php.PhpBuilder.Functions;
using AutoRest.Php.PhpBuilder.Statements;
using System.Collections.Generic;

namespace AutoRest.Php.PhpBuilder
{
    public static class PHP
    {
        /// <summary>
        /// [ items ]
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static Array Array(IEnumerable<ArrayItem> items)
            => new Array(items);

        /// <summary>
        /// [ items ]
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static Array Array(params ArrayItem[] items)
            => new Array(items);

        /// <summary>
        /// []
        /// </summary>
        public static Array EmptyArray { get; } = Array();

        /// <summary>
        /// key => value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ArrayItem KeyValue(StringConst key, Expression value)
            => new ArrayItem(key, value);

        /// <summary>
        /// value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ArrayItem KeyValue(Expression value)
            => new ArrayItem(null, value);

        /// <summary>
        /// key => value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ArrayItem KeyValue(string key, Expression value)
            => new ArrayItem(new StringConst(key), value);

        /// <summary>
        /// key => value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ArrayItem KeyValue(string key, string value)
            => new ArrayItem(new StringConst(key), new StringConst(value));

        public static Class Class(
            string name,
            Constructor constructor = null,
            IEnumerable<Function> functions = null,
            IEnumerable<Property> properties = null,
            IEnumerable<Const> consts = null)
            => new Class(
                name: new ClassName(name),
                constructor: constructor,
                functions: functions.EmptyIfNull(),
                properties: properties.EmptyIfNull(),
                consts: consts.EmptyIfNull());

        /// <summary>
        /// new type ( parameters )
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static New New(ClassName type, IEnumerable<Expression> parameters)
            => new New(type, parameters);

        /// <summary>
        /// new type ( parameters )
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static New New(ClassName type, params Expression[] parameters)
            => new New(type, parameters);

        /// <summary>
        /// new type ( parameters )
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Property Property(ClassName type, string name)
            => new Property(type, name);

        /// <summary>
        /// $this
        /// </summary>
        public static This This { get; } = new This();

        /// <summary>
        /// "value"
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StringConst String(string value)
            => new StringConst(value);

        /// <summary>
        /// self::name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Expression0 SelfScope(ConstName name)
            => new SelfConstRef(name);

        /// <summary>
        /// statements
        /// </summary>
        /// <param name="statements"></param>
        /// <returns></returns>
        public static IEnumerable<Statement> Statements(params Statement[] statements)
            => statements;

        /// <summary>
        /// return expression;
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Return Return(Expression expression)
            => new Return(expression);

        /// <summary>
        /// public function name ( parameters ) { body }
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="return"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static Function Function(
            string name,
            string description = null,
            IEnumerable<Parameter> parameters = null,
            ClassName @return = null,            
            IEnumerable<Statement> body = null)
            => new Function(
                name: name,
                description: description,                
                parameters: parameters.EmptyIfNull(),
                @return: @return,
                body: body);

        /// <summary>
        /// const name = expression ;
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Const Const(string name, Expression expression)
            => new Const(new ConstName(name), expression);

        /// <summary>
        /// private $name;
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Parameter Parameter(IType type, ObjectName name)
            => new Parameter(type, name);

        /// <summary>
        /// public function __constructor( parameters ) { statements }
        /// </summary>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="body"></param>
        /// <returns>PHP constructor</returns>
        public static Constructor Constructor(
            string description = null,
            IEnumerable<Parameter> parameters = null,
            IEnumerable<Statement> body = null)
            => new Constructor(
                description: description,
                parameters: parameters.EmptyIfNull(), 
                body: body.EmptyIfNull());

        public static IEnumerable<Parameter> Parameters(params Parameter[] parameters)
            => parameters;

        /// <summary>
        /// consts
        /// </summary>
        /// <param name="consts"></param>
        /// <returns></returns>
        public static IEnumerable<Const> Consts(params Const[] consts)
            => consts;
    }
}
