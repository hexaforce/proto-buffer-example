import * as jspb from 'google-protobuf'



export class SimpleMessage extends jspb.Message {
  getId(): number;
  setId(value: number): SimpleMessage;

  getMessageType(): SimpleMessage.Type;
  setMessageType(value: SimpleMessage.Type): SimpleMessage;

  getHeadersList(): Array<SimpleMessage.HeaderItem>;
  setHeadersList(value: Array<SimpleMessage.HeaderItem>): SimpleMessage;
  clearHeadersList(): SimpleMessage;
  addHeaders(value?: SimpleMessage.HeaderItem, index?: number): SimpleMessage.HeaderItem;

  getBlob(): Uint8Array | string;
  getBlob_asU8(): Uint8Array;
  getBlob_asB64(): string;
  setBlob(value: Uint8Array | string): SimpleMessage;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): SimpleMessage.AsObject;
  static toObject(includeInstance: boolean, msg: SimpleMessage): SimpleMessage.AsObject;
  static serializeBinaryToWriter(message: SimpleMessage, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): SimpleMessage;
  static deserializeBinaryFromReader(message: SimpleMessage, reader: jspb.BinaryReader): SimpleMessage;
}

export namespace SimpleMessage {
  export type AsObject = {
    id: number,
    messageType: SimpleMessage.Type,
    headersList: Array<SimpleMessage.HeaderItem.AsObject>,
    blob: Uint8Array | string,
  }

  export class HeaderItem extends jspb.Message {
    getName(): string;
    setName(value: string): HeaderItem;

    getValue(): string;
    setValue(value: string): HeaderItem;

    serializeBinary(): Uint8Array;
    toObject(includeInstance?: boolean): HeaderItem.AsObject;
    static toObject(includeInstance: boolean, msg: HeaderItem): HeaderItem.AsObject;
    static serializeBinaryToWriter(message: HeaderItem, writer: jspb.BinaryWriter): void;
    static deserializeBinary(bytes: Uint8Array): HeaderItem;
    static deserializeBinaryFromReader(message: HeaderItem, reader: jspb.BinaryReader): HeaderItem;
  }

  export namespace HeaderItem {
    export type AsObject = {
      name: string,
      value: string,
    }
  }


  export enum Type { 
    START = 0,
    BLOB = 1,
    END = 2,
  }
}

