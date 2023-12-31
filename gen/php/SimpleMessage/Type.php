<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: Bbb.proto

namespace SimpleMessage;

use UnexpectedValueException;

/**
 * Protobuf type <code>SimpleMessage.Type</code>
 */
class Type
{
    /**
     * Generated from protobuf enum <code>START = 0;</code>
     */
    const START = 0;
    /**
     * Generated from protobuf enum <code>BLOB = 1;</code>
     */
    const BLOB = 1;
    /**
     * Generated from protobuf enum <code>END = 2;</code>
     */
    const END = 2;

    private static $valueToName = [
        self::START => 'START',
        self::BLOB => 'BLOB',
        self::END => 'END',
    ];

    public static function name($value)
    {
        if (!isset(self::$valueToName[$value])) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no name defined for value %s', __CLASS__, $value));
        }
        return self::$valueToName[$value];
    }


    public static function value($name)
    {
        $const = __CLASS__ . '::' . strtoupper($name);
        if (!defined($const)) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no value defined for name %s', __CLASS__, $name));
        }
        return constant($const);
    }
}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Type::class, \SimpleMessage_Type::class);

