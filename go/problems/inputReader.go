package problems

import (
	"fmt"
	"log"
	"os"
)

const NewLine string = "\r\n"

func readProblemInput(id string) string {
	file, err := os.ReadFile(fmt.Sprintf("../../input/%s.txt", id))
	if err != nil {
		log.Fatalf("could not read problem file %s.txt", id)
	}
	return string(file)
}
