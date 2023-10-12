<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: Bbb.proto

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Generated from protobuf message <code>SimpleMessage</code>
 */
class SimpleMessage extends \Google\Protobuf\Internal\Message
{
    /**
     * Generated from protobuf field <code>uint64 id = 1;</code>
     */
    protected $id = 0;
    /**
     * Generated from protobuf field <code>.SimpleMessage.Type message_type = 2;</code>
     */
    protected $message_type = 0;
    /**
     * Generated from protobuf field <code>repeated .SimpleMessage.HeaderItem headers = 3;</code>
     */
    private $headers;
    /**
     * Generated from protobuf field <code>bytes blob = 4;</code>
     */
    protected $blob = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int|string $id
     *     @type int $message_type
     *     @type \SimpleMessage\HeaderItem[]|\Google\Protobuf\Internal\RepeatedField $headers
     *     @type string $blob
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Bbb::initOnce();
        parent::__construct($data);
    }

    /**
     * Generated from protobuf field <code>uint64 id = 1;</code>
     * @return int|string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * Generated from protobuf field <code>uint64 id = 1;</code>
     * @param int|string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkUint64($var);
        $this->id = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>.SimpleMessage.Type message_type = 2;</code>
     * @return int
     */
    public function getMessageType()
    {
        return $this->message_type;
    }

    /**
     * Generated from protobuf field <code>.SimpleMessage.Type message_type = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setMessageType($var)
    {
        GPBUtil::checkEnum($var, \SimpleMessage\Type::class);
        $this->message_type = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>repeated .SimpleMessage.HeaderItem headers = 3;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getHeaders()
    {
        return $this->headers;
    }

    /**
     * Generated from protobuf field <code>repeated .SimpleMessage.HeaderItem headers = 3;</code>
     * @param \SimpleMessage\HeaderItem[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setHeaders($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \SimpleMessage\HeaderItem::class);
        $this->headers = $arr;

        return $this;
    }

    /**
     * Generated from protobuf field <code>bytes blob = 4;</code>
     * @return string
     */
    public function getBlob()
    {
        return $this->blob;
    }

    /**
     * Generated from protobuf field <code>bytes blob = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setBlob($var)
    {
        GPBUtil::checkString($var, False);
        $this->blob = $var;

        return $this;
    }

}
