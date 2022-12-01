import * as fs from 'fs';
import * as path from 'path';

export function readFile(fileName: string) {
    const fileContents = fs.readFileSync(
        path.join(fileName),
        {
            encoding: 'utf-8',
        },
    );
    return fileContents;
};